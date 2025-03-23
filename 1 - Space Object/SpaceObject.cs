using System;
using System.Collections.Generic;

namespace SpaceSim
{ 
    public class SpaceObject
    {
        public string Name { get; protected set; }
        public int ObjectRadius { get; protected set; }
        public string Color { get; protected set; }
        public long OrbitalRadius { get; protected set; }  // Fixed naming (capitalized for consistency)
        public double OrbitalPeriod { get; protected set; }

        public SpaceObject(string name, int objectRadius, string color, long orbitalRadius = 0, double orbitalPeriod = 0)
        {
            Name = name;
            ObjectRadius = objectRadius;
            Color = color;
            OrbitalRadius = orbitalRadius;
            OrbitalPeriod = orbitalPeriod;
        }
        public double angVelo
        {
            get
            {
                if (OrbitalPeriod == 0) return 0;
                return (2 * Math.PI) / OrbitalPeriod;
            }
        }

        public double angPos(int time)
        {
            return angVelo * time;
        }

        public (double X, double Y) GetPosition(int time)
        {
            double angle = angPos(time);
            double x = OrbitalRadius * Math.Cos(angle);
            double y = OrbitalRadius * Math.Sin(angle);
            return (x, y);
        }

        public (double a, double b) GetMoonPosition(int time, Moon moon)
        {
            var (mx, my) = moon.GetPosition(time); // Get moon's position relative to the planet
            return (mx, my); 
        }

        public virtual void Draw()
        {
            Console.WriteLine($"{Name} (Color: {Color}, Radius: {ObjectRadius} km");
        }
    }

    public class Star : SpaceObject
    {
        public int rotationalPeriod { get; protected set; }
        public Star(String name, int rotationalPeriod, int objectRadius, String color) : base(name, objectRadius, color) { }
        public override void Draw()
        {
            Console.Write("Star  : ");
            base.Draw();
        }
    }
    public class Moon : SpaceObject
    {
        public Moon(string name, double orbitalPeriod, int orbitalRadius, int objectRadius, string color)
            : base(name, objectRadius, color, orbitalRadius, orbitalPeriod) // Pass values to base class
        {
        }

        public (double X, double Y) GetPositionMoon(int days, (double X, double Y) planetPosition)
        {
            var (px, py) = planetPosition;
            double angle = 2 * Math.PI * (days / (OrbitalPeriod * 365.25)); // Convert years to days
            double x = px + OrbitalRadius * Math.Cos(angle);
            double y = py + OrbitalRadius * Math.Sin(angle);
            return (x, y);
        }



        public override void Draw()
        {
            Console.Write("        Moon  : ");
            base.Draw();
        }
    }


    public class Planet : SpaceObject
    {
        public int RotationalPeriod { get; protected set; }

        public List<Moon> Moons { get; } = new List<Moon>();

        public Planet(string name, double orbitalPeriod, long orbitalRadius, int objectRadius, int rotationalPeriod, string color)
            : base(name, objectRadius, color, orbitalRadius, orbitalPeriod) // Pass values to base class
        {
            RotationalPeriod = rotationalPeriod;
        }



        public override void Draw()
        {
            Console.Write("    Planet: ");
            base.Draw();
            foreach (var moon in Moons)
            {
                moon.Draw();
            }
        }
    }

    public class DwarfPlanet : SpaceObject
    {
        public long orbitalRadius { get; protected set; }
        public double orbitalPeriod { get; protected set; }
        public int rotationalPeriod { get; protected set; }

        public List<Moon> Moons { get; } = new List<Moon>();
        public DwarfPlanet(String name, double orbitalPeriod, long orbitalRadius, int objectRadius, int rotationalPeriod, String color) : base(name, objectRadius, color) { }

        public virtual (double X, double Y) GetPosition(int days)
        {
            double angle = 2 * Math.PI * (days / (orbitalPeriod * 365.25)); // Convert years to days
            double x = orbitalRadius * Math.Cos(angle);
            double y = orbitalRadius * Math.Sin(angle);
            return (x, y);
        }

        public override void Draw()
        {
            Console.Write("    DwarfPlanet: ");
            base.Draw();
            foreach(var moon in Moons)
            {
                moon.Draw();
            }
        }
    }

    public class Asteroid : SpaceObject
    {
        public Asteroid(string name, int objectRadius, string color) : base(name, objectRadius, color) { }
        public override void Draw()
        {
            Console.Write("    Asteroid : ");
                base.Draw();
        }
    }

    public class AsteroidBelt : SpaceObject
    {
        public AsteroidBelt(string name, int objectRadius, string color) : base(name, objectRadius, color) { }
        public override void Draw()
        {
            Console.Write("    Asteroid Belt : ");
            base.Draw();
        }
    }
}

