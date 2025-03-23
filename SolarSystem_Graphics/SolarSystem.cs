using System;
using System.Collections.Generic;
using SpaceSim;

namespace SolarSystem_Graphics
{
    public static class SolarSystem
    {
        // Scales for orbital periods, orbital radii, and object radii
        private static double orbPeriodScale = 0.000001;
        private static double objRadiusScale = 0.007;
        private static double moonRadiusScale = 0.0001;
        private static double moonPeriodScale = 0.00297;

        public static List<SpaceObject> GetSpaceObjects()
        {
            return new List<SpaceObject>
            {
                // Our central star
                new Star("Sun", 648, 695000 * 0.0001, "Yellow"),

                // Mercury
                new Planet("Mercury", 88,
                           57910000 * orbPeriodScale,
                           2440 * objRadiusScale,
                           548,
                           "LightGray"),

                // Venus
                new Planet("Venus", 225,
                           108200000 * orbPeriodScale,
                           6051 * objRadiusScale,
                           5832,
                           "Orange"),

                // Earth (with Moon)
                new Planet("Terra", 365,
                            150000000 * orbPeriodScale,
                            6378 * objRadiusScale,
                            24,
                            "Blue")
                {
                    Moons =
                    {
                        new Moon("The Moon",
                                 28 * moonPeriodScale,          // ~28 days => scaled to fraction of a year
                                 38400 * moonRadiusScale,       // 384,000 km => scaled
                                 1737 * objRadiusScale,         // Moon's ~1737 km radius => scaled
                                 "Gray")
                    }
                },

                // Mars (Phobos & Deimos)
                new Planet("Mars", 687,
                           227940000 * orbPeriodScale,
                           3389 * objRadiusScale,
                           25,
                           "Red")
                {
                    Moons =
                    {
                        new Moon("Phobos",
                                 0.32 * moonPeriodScale,        // ~8 hours => ~0.32 day
                                 9377 * moonRadiusScale,        // 9,377 km from Mars center => scaled
                                 11 * objRadiusScale,           // ~11 km radius => scaled
                                 "Gray"),
                        new Moon("Deimos",
                                 1.26 * moonPeriodScale,        // ~30 hours => ~1.26 days
                                 23460 * moonRadiusScale,       // 23,460 km => scaled
                                 6 * objRadiusScale,            // ~6 km radius => scaled
                                 "Gray")
                    }
                },

                //----------------------------------------------------------------------
                // JUPITER + Moons
                //----------------------------------------------------------------------
                new Planet("Jupiter", 4333,
                           778330000 * orbPeriodScale,
                           69911 * objRadiusScale,
                           10,
                           "Bisque")
                {
                    Moons =
                    {
                        // Period=1 => 1 day => multiply by moonPeriodScale => fraction of a year
                        // Radius=128000 => orbital radius => multiply by moonRadiusScale => display
                        // objectRadius => multiply by objRadiusScale => physical size on display
                        new Moon("Metis",      1   * moonPeriodScale, 128000   * moonRadiusScale,  21.5   * objRadiusScale, "Gray"),
                        new Moon("Adrastea",   1   * moonPeriodScale, 129000   * moonRadiusScale,  8.2    * objRadiusScale, "Gray"),
                        new Moon("Amalthea",   1   * moonPeriodScale, 181000   * moonRadiusScale,  83.5   * objRadiusScale, "Gray"),
                        new Moon("Thebe",      1   * moonPeriodScale, 222000   * moonRadiusScale,  49.3   * objRadiusScale, "Gray"),
                        new Moon("Io",         2   * moonPeriodScale, 422000   * moonRadiusScale,  1821.6 * objRadiusScale, "Gray"),
                        new Moon("Europa",     4   * moonPeriodScale, 671000   * moonRadiusScale,  1560.8 * objRadiusScale, "Gray"),
                        new Moon("Ganymede",   7   * moonPeriodScale, 1070000  * moonRadiusScale,  2634.1 * objRadiusScale, "Gray"),
                        new Moon("Callisto",   17  * moonPeriodScale, 1883000  * moonRadiusScale,  2410.3 * objRadiusScale, "Gray"),
                        //new Moon("Leda",       239 * moonPeriodScale, 11094000 * moonRadiusScale,  10     * objRadiusScale, "Gray"),
                        //new Moon("Himalia",    251 * moonPeriodScale, 11480000 * moonRadiusScale,  85     * objRadiusScale, "Gray"),
                        //new Moon("Lysithea",   259 * moonPeriodScale, 11720000 * moonRadiusScale,  18     * objRadiusScale, "Gray"),
                        //new Moon("Elara",      260 * moonPeriodScale, 11737000 * moonRadiusScale,  43     * objRadiusScale, "Gray"),
                        //new Moon("Ananke",    -631 * moonPeriodScale, 21200000 * moonRadiusScale,  14     * objRadiusScale, "Gray"),
                        //new Moon("Carme",     -692 * moonPeriodScale, 22600000 * moonRadiusScale,  23     * objRadiusScale, "Gray"),
                        //new Moon("Pasiphae",  -735 * moonPeriodScale, 23500000 * moonRadiusScale,  30     * objRadiusScale, "Gray"),
                        //new Moon("Sinope",    -758 * moonPeriodScale, 23700000 * moonRadiusScale,  19     * objRadiusScale, "Gray")
                    }
                },

                //----------------------------------------------------------------------
                // SATURN + Moons
                //----------------------------------------------------------------------
                new Planet("Saturn", 10760,
                           1429400000 * orbPeriodScale,
                           58232 * objRadiusScale,
                           11,
                           "Khaki")
                {
                    Moons =
                    {
                        new Moon("Pan",         1   * moonPeriodScale,  134000   * moonRadiusScale, 14   * objRadiusScale, "Gray"),
                        new Moon("Atlas",       1   * moonPeriodScale,  138000   * moonRadiusScale, 15   * objRadiusScale, "Gray"),
                        new Moon("Prometheus",  1   * moonPeriodScale,  139000   * moonRadiusScale, 43   * objRadiusScale, "Gray"),
                        new Moon("Pandora",     1   * moonPeriodScale,  142000   * moonRadiusScale, 42   * objRadiusScale, "Gray"),
                        new Moon("Epimetheus",  1   * moonPeriodScale,  151000   * moonRadiusScale, 58   * objRadiusScale, "Gray"),
                        new Moon("Janus",       1   * moonPeriodScale,  151000   * moonRadiusScale, 90   * objRadiusScale, "Gray"),
                        new Moon("Mimas",       1   * moonPeriodScale,  186000   * moonRadiusScale, 198  * objRadiusScale, "Gray"),
                        new Moon("Enceladus",   1   * moonPeriodScale,  238000   * moonRadiusScale, 252  * objRadiusScale, "Gray"),
                        new Moon("Tethys",      2   * moonPeriodScale,  295000   * moonRadiusScale, 531  * objRadiusScale, "Gray"),
                        new Moon("Telesto",     2   * moonPeriodScale,  295000   * moonRadiusScale, 12   * objRadiusScale, "Gray"),
                        new Moon("Calypso",     2   * moonPeriodScale,  295000   * moonRadiusScale, 10   * objRadiusScale, "Gray"),
                        new Moon("Dione",       3   * moonPeriodScale,  377000   * moonRadiusScale, 561  * objRadiusScale, "Gray"),
                        new Moon("Helene",      3   * moonPeriodScale,  377000   * moonRadiusScale, 17   * objRadiusScale, "Gray"),
                        new Moon("Rhea",        5   * moonPeriodScale,  527000   * moonRadiusScale, 763  * objRadiusScale, "Gray"),
                        new Moon("Titan",       16  * moonPeriodScale,  1222000  * moonRadiusScale, 2575 * objRadiusScale, "Gray"),
                        new Moon("Hyperion",    21  * moonPeriodScale,  1481000  * moonRadiusScale, 135  * objRadiusScale, "Gray"),
                        new Moon("Iapetus",     79  * moonPeriodScale,  3561000  * moonRadiusScale, 734  * objRadiusScale, "Gray"),
                        //new Moon("Phoebe",     -550 * moonPeriodScale, 12952000 * moonRadiusScale, 106  * objRadiusScale, "Gray")
                    }
                },

                //----------------------------------------------------------------------
                // URANUS + Moons
                //----------------------------------------------------------------------
                new Planet("Uranus", 30685,
                           2870990000 * orbPeriodScale,
                           25362 * objRadiusScale,
                           17,
                           "LightBlue")
                {
                    Moons =
                    {
                        new Moon("Cordelia",   1   * moonPeriodScale, 50000   * moonRadiusScale,  20   * objRadiusScale, "Gray"),
                        new Moon("Ophelia",    1   * moonPeriodScale, 54000   * moonRadiusScale,  20   * objRadiusScale, "Gray"),
                        new Moon("Bianca",     1   * moonPeriodScale, 59000   * moonRadiusScale,  22   * objRadiusScale, "Gray"),
                        new Moon("Cressida",   1   * moonPeriodScale, 62000   * moonRadiusScale,  41   * objRadiusScale, "Gray"),
                        new Moon("Desdemona",  1   * moonPeriodScale, 63000   * moonRadiusScale,  35   * objRadiusScale, "Gray"),
                        new Moon("Juliet",     1   * moonPeriodScale, 64000   * moonRadiusScale,  46   * objRadiusScale, "Gray"),
                        new Moon("Portia",     1   * moonPeriodScale, 66000   * moonRadiusScale,  68   * objRadiusScale, "Gray"),
                        new Moon("Rosalind",   1   * moonPeriodScale, 70000   * moonRadiusScale,  36   * objRadiusScale, "Gray"),
                        new Moon("Belinda",    1   * moonPeriodScale, 75000   * moonRadiusScale,  45   * objRadiusScale, "Gray"),
                        new Moon("Puck",       1   * moonPeriodScale, 86000   * moonRadiusScale,  81   * objRadiusScale, "Gray"),
                        new Moon("Miranda",    1   * moonPeriodScale, 130000  * moonRadiusScale,  235  * objRadiusScale, "Gray"),
                        new Moon("Ariel",      3   * moonPeriodScale, 191000  * moonRadiusScale,  579  * objRadiusScale, "Gray"),
                        new Moon("Umbriel",    4   * moonPeriodScale, 266000  * moonRadiusScale,  585  * objRadiusScale, "Gray"),
                        new Moon("Titania",    9   * moonPeriodScale, 436000  * moonRadiusScale,  788  * objRadiusScale, "Gray"),
                        new Moon("Oberon",     13  * moonPeriodScale, 583000  * moonRadiusScale,  761  * objRadiusScale, "Gray"),
                        //new Moon("Caliban",   -580 * moonPeriodScale, 7169000 * moonRadiusScale,  42   * objRadiusScale, "Gray"),
                        //new Moon("Stephano",  -674 * moonPeriodScale, 7948000 * moonRadiusScale,  20   * objRadiusScale, "Gray"),
                        //new Moon("Sycorax",   -1289* moonPeriodScale, 12213000* moonRadiusScale,  78   * objRadiusScale, "Gray"),
                        //new Moon("Prospero",  -2019* moonPeriodScale, 16568000* moonRadiusScale,  25   * objRadiusScale, "Gray"),
                        //new Moon("Setebos",   -2239* moonPeriodScale, 17681000* moonRadiusScale,  24   * objRadiusScale, "Gray")
                    }
                },

                //----------------------------------------------------------------------
                // NEPTUNE + Moons
                //----------------------------------------------------------------------
                new Planet("Neptune", 60190,
                           4504300000 * orbPeriodScale,
                           24622 * objRadiusScale,
                           16,
                           "Blue")
                {
                    Moons =
                    {
                        new Moon("Naiad",      1   * moonPeriodScale, 48000   * moonRadiusScale, 29   * objRadiusScale, "Gray"),
                        new Moon("Thalassa",   1   * moonPeriodScale, 50000   * moonRadiusScale, 41   * objRadiusScale, "Gray"),
                        new Moon("Despina",    1   * moonPeriodScale, 53000   * moonRadiusScale, 75   * objRadiusScale, "Gray"),
                        new Moon("Galatea",    1   * moonPeriodScale, 62000   * moonRadiusScale, 88   * objRadiusScale, "Gray"),
                        new Moon("Larissa",    1   * moonPeriodScale, 74000   * moonRadiusScale, 97   * objRadiusScale, "Gray"),
                        new Moon("Proteus",    1   * moonPeriodScale, 118000  * moonRadiusScale, 210  * objRadiusScale, "Gray"),
                        new Moon("Triton",    -6   * moonPeriodScale, 355000  * moonRadiusScale, 1353 * objRadiusScale, "Gray"),
                        new Moon("Nereid",     360 * moonPeriodScale, 5513000 * moonRadiusScale, 170  * objRadiusScale, "Gray")
                    }
                },

                //----------------------------------------------------------------------
                // PLUTO + Moons
                //----------------------------------------------------------------------
                new DwarfPlanet("Pluto", 90550,
                                5913520000 * orbPeriodScale,
                                1188 * objRadiusScale,
                                153,
                                "Beige")
                {
                    Moons =
                    {
                        new Moon("Charon",  6  * moonPeriodScale, 20000  * moonRadiusScale, 606 * objRadiusScale, "Gray"),
                        new Moon("Nix",     25 * moonPeriodScale, 49000  * moonRadiusScale, 23  * objRadiusScale, "Gray"),
                        new Moon("Hydra",   38 * moonPeriodScale, 65000  * moonRadiusScale, 31  * objRadiusScale, "Gray")
                    }
                }
            };
        }
    }
}
