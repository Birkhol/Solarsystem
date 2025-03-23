using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaceSim;


namespace SolarSystem_Graphics
{
    public static class SolarSystem
    {

        private static double orbPeriodScale = 0.000001;
        private static double objRadiusScale = 0.007;
        private static double moonRadiusScale = 0.0001;
        private static double moonPeriodScale = 0.00297;

        public static List<SpaceObject> GetSpaceObjects()
        {
            return new List<SpaceObject>
            {
                new Star("Sun", 648, 695000*0.0001, "Yellow"),
                new Planet("Mercury", 88, 57910000*orbPeriodScale, 2440*objRadiusScale, 548, "LightGray"),
                new Planet("Venus", 225, 108200000*orbPeriodScale, 6051*objRadiusScale, 5832, "Orange"),
                new Planet("Terra", 365, 150000000*orbPeriodScale, 6378*objRadiusScale, 24, "Blue")
                {
                    Moons =
                    {
                        new Moon("The Moon", 28*moonPeriodScale, 38400*moonRadiusScale, 1737*objRadiusScale, "Gray")
                    }
                },
                new Planet("Mars", 687, 227940000*orbPeriodScale, 3389*objRadiusScale, 25, "Red")
                {
                    Moons =
                    {
                        new Moon("Phobos", 0.32*moonPeriodScale, 9377*moonRadiusScale, 11, "Gray"),
                        new Moon("Deimos", 1.26*moonPeriodScale, 23460*moonRadiusScale, 6, "Gray")
                    }
                },
                new Planet("Jupiter", 4333, 778330000*orbPeriodScale, 69911*objRadiusScale, 10, "Bisque"),

                new Planet("Saturn", 10760, 1429400000*orbPeriodScale, 58232*objRadiusScale, 11, "Khaki"),

                new Planet("Uranus", 30685, 2870990000*orbPeriodScale, 25362*objRadiusScale, 17, "LightBlue"),

                new Planet("Neptune", 60190, 4504300000*orbPeriodScale, 24622*objRadiusScale, 16, "Blue"),

                new DwarfPlanet("Pluto", 90550, 5913520000*orbPeriodScale, 1188*objRadiusScale, 153, "Beige"),


            };
        }
    }
}
