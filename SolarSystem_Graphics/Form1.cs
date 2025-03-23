using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SpaceSim;

namespace SolarSystem_Graphics
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        private int time;
        private List<SpaceObject> spaceObjects;
        private bool showLabels = true;
        private bool showOrbits = true;
        private double scaleFactor = 1.8;
        private double SizeFactor = 0.5;
        private SimulationClock simulationClock;

        // Added field for zoom mode
        private Planet zoomedPlanet = null;

        // Delegate and event for tick notifications (DoTick)
        public delegate void TickEventHandler(int time);
        public event TickEventHandler DoTick;
        private bool showPlanetInfo = true;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            // UI controls to toggle labels and orbits
            CheckBox labelsCheckBox = new CheckBox
            {
                Text = "Show Labels",
                Checked = showLabels,
                Location = new Point(10, 120)
            };
            labelsCheckBox.CheckedChanged += (s, e) => { showLabels = labelsCheckBox.Checked; Invalidate(); };
            Controls.Add(labelsCheckBox);

            CheckBox orbitsCheckBox = new CheckBox
            {
                Text = "Show Orbits",
                Checked = showOrbits,
                Location = new Point(10, 160)
            };
            orbitsCheckBox.CheckedChanged += (s, e) => { showOrbits = orbitsCheckBox.Checked; Invalidate(); };
            Controls.Add(orbitsCheckBox);

            CheckBox infoCheckBox = new CheckBox
            {
                Text = "Show Info",
                Checked = showPlanetInfo,
                Location = new Point(10, 200)
            };
            infoCheckBox.CheckedChanged += (s, e) => { showPlanetInfo = infoCheckBox.Checked; Invalidate(); };
            Controls.Add(infoCheckBox);


            // Get space objects from the solar system
            spaceObjects = SolarSystem.GetSpaceObjects();

            //create and start the simulation clock
            simulationClock = new SimulationClock();
            simulationClock.DoTick += SimulationClock_DoTick;
            simulationClock.Start();


         

            // Enable mouse wheel zoom for the overall view
            this.MouseWheel += (s, e) => Zoom(e.Delta);

            this.KeyDown += Form1_KeyDown;
            this.KeyPreview = true;
        }
        //event handler for updating time and refreshing the drawing
        private void SimulationClock_DoTick(int currentTime)
        {
            time = currentTime;
            Invalidate();
        }
        // key press handler for speed
        private void Form1_KeyDown(Object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.W)
            {
                simulationClock.SpeedFactor *= 1.2;
            }
            else if (e.KeyCode ==Keys.S)
            {
                simulationClock.SpeedFactor /= 1.2;
            }
               
        }

        // Zoom in/out on mouse wheel scroll
        private void Zoom(int delta)
        {
            if (delta > 0)
            {
                scaleFactor *= 1.1; // Zoom in by increasing scaleFactor
            }
            else if (delta < 0)
            {
                scaleFactor /= 1.1; // Zoom out by decreasing scaleFactor
            }
            Invalidate();
        }

        // Override OnMouseDown to allow clicking on a planet to zoom in,
        // and right-clicking to return to the full solar system view.
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;

            // Left-click: try to zoom in on a planet if not already zoomed in.
            if (e.Button == MouseButtons.Left)
            {
                if (zoomedPlanet == null)
                {
                    // Loop through space objects and check if a planet was clicked.
                    foreach (var obj in spaceObjects)
                    {
                        if (obj is Planet planet)
                        {
                            var (x, y) = planet.GetPosition(time);
                            int drawX = centerX + (int)(x * scaleFactor);
                            int drawY = centerY + (int)(y * scaleFactor);
                            double size = planet.ObjectRadius * SizeFactor;
                            double distance = Math.Sqrt(Math.Pow(e.X - drawX, 2) + Math.Pow(e.Y - drawY, 2));
                            if (distance <= size)
                            {
                                zoomedPlanet = planet; // Enter zoom mode on the clicked planet.
                                break;
                            }
                        }
                    }
                }
            }
            // Right-click: exit zoom mode and return to overview.
            else if (e.Button == MouseButtons.Right)
            {
                zoomedPlanet = null;
            }
            Invalidate();
        }

        // Updated OnPaint to handle both full solar system view and zoomed view.
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;

            if (zoomedPlanet == null)
            {
                // Full solar system view
                foreach (var obj in spaceObjects)
                {
                    if (obj is Star)
                    {
                        DrawObject(g, obj, centerX, centerY);
                        if (showLabels)
                            DrawLabel(g, obj, centerX, centerY);
                    }
                    else if (obj is Planet planet)
                    {
                        var (x, y) = planet.GetPosition(time);
                        int drawX = centerX + (int)(x * scaleFactor);
                        int drawY = centerY + (int)(y * scaleFactor);
                        DrawObject(g, planet, drawX, drawY);
                        if (showLabels)
                            DrawLabel(g, planet, drawX, drawY);

                        // Draw the planet's moons
                        foreach (var moon in planet.Moons)
                        {
                            var (mx, my) = moon.GetPositionMoon(time, (x, y));
                            int moonX = centerX + (int)(mx * scaleFactor);
                            int moonY = centerY + (int)(my * scaleFactor);
                            DrawObject(g, moon, moonX, moonY);
                            if (showLabels)
                                DrawLabel(g, moon, moonX, moonY);
                        }

                        // Draw planet orbit if toggled on.
                        if (showOrbits)
                        {
                            DrawOrbit(g, planet, centerX, centerY);
                        }
                    }
                }
            }
            else
            {
                // Zoomed in view: Draw the selected planet centered.
                DrawObject(g, zoomedPlanet, centerX, centerY);
                if (showLabels)
                    DrawLabel(g, zoomedPlanet, centerX, centerY);

                // Draw the moons orbiting the zoomed-in planet.
                foreach (var moon in zoomedPlanet.Moons)
                {
                    // Get moon position relative to planet (assumed at (0,0) in this view).
                    var (mx, my) = moon.GetPositionMoon(time, (0, 0));
                    int moonX = centerX + (int)(mx * scaleFactor);
                    int moonY = centerY + (int)(my * scaleFactor);
                    DrawObject(g, moon, moonX, moonY);
                    if (showLabels)
                        DrawLabel(g, moon, moonX, moonY);

                    // Draw moon orbit if toggled on.
                    if (showOrbits)
                    {
                        Pen orbitPen = new Pen(Color.Gray, 1) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dot };
                        int orbitRadius = (int)(moon.OrbitalRadius * scaleFactor);
                        g.DrawEllipse(orbitPen, centerX - orbitRadius, centerY - orbitRadius, 2 * orbitRadius, 2 * orbitRadius);
                    }
                }

                // Display detailed planet data in the top-left corner.
                if(showPlanetInfo) 
                { 
                string planetInfo = $"Planet: {zoomedPlanet.Name}\n" +
                                    $"Orbital Period: {zoomedPlanet.OrbitalPeriod}\n" +
                                    $"Orbital Radius: {zoomedPlanet.OrbitalRadius}\n" +
                                    $"Object Radius: {zoomedPlanet.ObjectRadius}\n" +
                                    $"Rotational Period: {zoomedPlanet.RotationalPeriod}";
                Font infoFont = new Font("Arial", 10);
                Brush infoBrush = new SolidBrush(Color.White);
                g.DrawString(planetInfo, infoFont, infoBrush, 10, 10);
                }
            }
        }

        // Draw a space object (star, planet, moon, etc.)
        private void DrawObject(Graphics g, SpaceObject obj, int x, int y)
        {
            Color color = Color.FromName(obj.Color);
            Brush brush = new SolidBrush(color);
            double size = obj.ObjectRadius * SizeFactor;
            g.FillEllipse(brush, (int)(x - size / 2), (int)(y - size / 2), (int)size, (int)size);
        }

        // Draw the label for a space object.
        private void DrawLabel(Graphics g, SpaceObject obj, int x, int y)
        {
            Font font = new Font("Arial", 8);
            Brush brush = new SolidBrush(Color.White);
            g.DrawString(obj.Name, font, brush, x + 5, y - 10);
        }

        // Draw the orbit for a planet (in the full solar system view).
        private void DrawOrbit(Graphics g, Planet planet, int centerX, int centerY)
        {
            Pen orbitPen = new Pen(Color.Gray, 1) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dot };
            int orbitRadius = (int)(planet.OrbitalRadius * scaleFactor);
            g.DrawEllipse(orbitPen, centerX - orbitRadius, centerY - orbitRadius, 2 * orbitRadius, 2 * orbitRadius);
        }
    }
}
