using System.DirectoryServices;
using System.Windows.Forms;
using System.Drawing;
using SpaceSim;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

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

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            // UI controls to toggle tags of object
            CheckBox labelsCheckBox = new CheckBox
            {
                Text = "Show Labels",
                Checked = showLabels,
                Location = new Point(10, 10)
            };
            labelsCheckBox.CheckedChanged += (s, e) => showLabels = labelsCheckBox.Checked;
            Controls.Add(labelsCheckBox);

            CheckBox orbitsCheckBox = new CheckBox
            {
                Text = "Show Orbits",
                Checked = showOrbits,
                Location = new Point(10, 40)
            };
            orbitsCheckBox.CheckedChanged += (s, e) => showOrbits = orbitsCheckBox.Checked;
            Controls.Add(orbitsCheckBox);

            spaceObjects = SolarSystem.GetSpaceObjects();

            timer = new System.Windows.Forms.Timer { Interval = 50 };
            timer.Tick += (s, e) => { time++; Invalidate(); };
            timer.Start();

            // Enable mouse wheel zoom
            this.MouseWheel += (s, e) => Zoom(e.Delta);

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

        private void Timer_Tick(object? sender, EventArgs e)
        {
            
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;

            foreach (var obj in spaceObjects)
            {
                if (obj is Star)
                {
                    DrawObject(g, obj, centerX, centerY);
                    if (showLabels) DrawLabel(g, obj, centerX, centerY);
                }
                else if (obj is Planet planet)
                {
                    var (x, y) = planet.GetPosition(time);
                    int drawX = centerX + (int)(x*scaleFactor);
                    int drawY = centerY + (int)(y*scaleFactor);
                    DrawObject(g, planet, drawX, drawY);
                    if (showLabels) DrawLabel(g, planet, drawX, drawY);

                    foreach (var moon in planet.Moons)
                    {
                        var (mx, my) = moon.GetPositionMoon(time, (x, y));
                        int moonX = centerX + (int)(mx*scaleFactor);
                        int moonY = centerY + (int)(my*scaleFactor);
                        DrawObject(g, moon, moonX, moonY);
                        if (showLabels) DrawLabel(g, moon, moonX, moonY);
                    }

                    if (showOrbits)
                    {
                        DrawOrbit(g, planet, centerX, centerY);
                    }

                }
            }
        }

        private void DrawObject(Graphics g, SpaceObject obj, int x, int y)
        {
            Color color = Color.FromName(obj.Color);
            Brush brush = new SolidBrush(color);
            double size = obj.ObjectRadius*SizeFactor;
            g.FillEllipse(brush, (int)(x - size / 2), (int)(y - size / 2), (int)size, (int)size);
        }

        // Draws label for space object
        private void DrawLabel(Graphics g, SpaceObject obj, int x, int y)
        {
            Font font = new Font("Arial", 8);
            Brush brush = new SolidBrush(Color.White);
            g.DrawString(obj.Name, font, brush, x + 5, y - 10);
        }

        private void DrawOrbit(Graphics g, Planet planet, int centerX, int centerY)
        {
            Pen orbitPen = new Pen(Color.Gray, 1) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dot };
            int orbitRadius = (int)(planet.OrbitalRadius*scaleFactor);
            g.DrawEllipse(orbitPen, centerX - orbitRadius, centerY - orbitRadius, 2 * orbitRadius, 2 * orbitRadius);
        }


    }
}
