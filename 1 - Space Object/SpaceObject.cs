using System;
using System.Collections.Generic;

namespace SpaceSim
{
    public class SpaceObject
    {
        public String Name { get; protected set; }
        public int ObjectRadius { get; protected set; }
        public String Color { get; protected set; }

        public SpaceObject(String name, int objectRadius, String color)
        {
            Name = name;
            ObjectRadius = objectRadius;
            Color = color;
        }

        public virtual void Draw()
        {
            Console.WriteLine($"{Name} (Color: {Color}, Radius: {ObjectRadius} km");
        }
    }

    public class Star : SpaceObject
    {
        public Star(String name, int rotationalPeriod, int objectRadius, String color) : base(name, objectRadius, color) { }
        public override void Draw()
        {
            Console.Write("Star  : ");
            base.Draw();
        }
    }
    public class Moon : SpaceObject
    {
        public Moon(String name, double orbitalPeriod, int orbitalRadius, int objectRadius, String color) : base(name, objectRadius, color) { }

        public override void Draw()
        {
            Console.Write("        Moon  : ");
            base.Draw();
        }
    }


    public class Planet : SpaceObject
    {
        public List<Moon> Moons { get; } = new List<Moon>();
        public Planet(String name, double orbitalPeriod, long orbitalRadius, int objectRadius, int rotationalPeriod, String color) : base(name, objectRadius, color) { }
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
        public List<Moon> Moons { get; } = new List<Moon>();
        public DwarfPlanet(String name, double orbitalPeriod, long orbitalRadius, int objectRadius, int rotationalPeriod, String color) : base(name, objectRadius, color) { }
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

