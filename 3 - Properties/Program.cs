using System;
using System.Collections.Generic;
using System.Text;


namespace Properties {
    class Program {
        static void Main() {

            Dictionary<string, Body> solarSystem = new Dictionary<string, Body>();

            // Standard traditional syntax
            Body sun = new Body("Sol");
            sun.Radius = 0;
            sun.Period = 0;
            sun.objectRadius = 695000;
            sun.rotationalPeriod = 648;
            sun.objectColor = "Yellow";
            solarSystem["Sun"] = sun;

            // Using object initilaizers instead
            Body earth = new Body("Terra")
            {
                Period = 365,
                Radius = 150000000,
                objectRadius = 6378,
                rotationalPeriod = 24,
                objectColor = "Blue"
            };
            sun[2] = earth;
            solarSystem["Earth"] = earth;

            // And now with simplified "new" statement
            Body moon = new("The Moon") {Period = 28,Radius = 384000, objectRadius = 1737, rotationalPeriod = 648, objectColor = "Gray"};
            earth[0] = moon;
            solarSystem["Moon"] = moon;



            Body mercury = new Body("Mercury") { Period = 88, Radius = 57910000, objectRadius = 2440, rotationalPeriod = 1416, objectColor = "Gray" };
            sun[0] = mercury;
            solarSystem["Mercury"] = mercury;


            Body venus = new Body("Venus") { Period = 225, Radius = 108200000, objectRadius = 6051, rotationalPeriod = 5832, objectColor = "Orange" };
            sun[1] = venus;
            solarSystem["Venus"] = venus;

            Body mars = new Body("Mars") { Period = 687, Radius = 227940000, objectRadius = 3389, rotationalPeriod = 25, objectColor = "Red" };
            mars[0] = new Body("Phobos") { Period = 8, Radius = 9377 };

            mars[1] = new Body("Deimos") { Period = 30, Radius = 23460 };

            sun[3] = mars;
            solarSystem["Mars"] = mars;

            Body jupiter = new Body("Jupiter") { Period = 4333, Radius = 778330000, objectRadius = 69911, rotationalPeriod = 10, objectColor = "Beige" };
            jupiter[0] = new Body("Metis") { Period = 1, Radius = 128000 };
            jupiter[1] = new Body("Adrastea") { Period = 1, Radius = 129000 };
            jupiter[2] = new Body("Amalthea") { Period = 1, Radius = 181000 };
            jupiter[3] = new Body("Thebe") { Period = 1, Radius = 222000 };
            jupiter[4] = new Body("Io") { Period = 2, Radius = 422000 };
            jupiter[5] = new Body("Europa") { Period = 4, Radius = 671000 };
            jupiter[6] = new Body("Ganymede") { Period = 7, Radius = 1070000 };
            jupiter[7] = new Body("Callisto") { Period = 17, Radius = 1883000 };
            jupiter[8] = new Body("Leda") { Period = 239, Radius = 11094000 };
            jupiter[9] = new Body("Himalia") { Period = 251, Radius = 11480000 };
            jupiter[10] = new Body("Lysithea") { Period = 259, Radius = 11720000 };
            jupiter[11] = new Body("Elara") { Period = 260, Radius = 11737000 };
            jupiter[12] = new Body("Ananke") { Period = -631, Radius = 21200000 };
            jupiter[13] = new Body("Carme") { Period = -692, Radius = 22600000 };
            jupiter[14] = new Body("Pasiphae") { Period = -735, Radius = 23500000 };
            jupiter[15] = new Body("Sinope") { Period = -758, Radius = 23700000 };
            sun[4] = jupiter;
            solarSystem["Jupiter"] = jupiter;

            Body saturn = new Body("Saturn") { Period = 10760, Radius = 1429400000, objectRadius = 58232, rotationalPeriod = 11, objectColor = "Latte" };
            saturn[0] = new Body("Pan") { Period = 1, Radius = 134000 };
            saturn[1] = new Body("Atlas") { Period = 1, Radius = 138000 };
            saturn[2] = new Body("Prometheus") { Period = 1, Radius = 139000 };
            saturn[3] = new Body("Pandora") { Period = 1, Radius = 142000 };
            saturn[4] = new Body("Epimetheus") { Period = 1, Radius = 151000 };
            saturn[5] = new Body("Janus") { Period = 1, Radius = 151000 };
            saturn[6] = new Body("Mimas") { Period = 1, Radius = 186000 };
            saturn[7] = new Body("Enceladus") { Period = 1, Radius = 238000 };
            saturn[8] = new Body("Tethys") { Period = 2, Radius = 295000 };
            saturn[9] = new Body("Telesto") { Period = 2, Radius = 295000 };
            saturn[10] = new Body("Calypso") { Period = 2, Radius = 295000 };
            saturn[11] = new Body("Dione") { Period = 3, Radius = 377000 };
            saturn[12] = new Body("Helene") { Period = 3, Radius = 377000 };
            saturn[13] = new Body("Rhea") { Period = 5, Radius = 527000 };
            saturn[14] = new Body("Titan") { Period = 16, Radius = 1222000 };
            saturn[15] = new Body("Hyperion") { Period = 21, Radius = 1481000 };
            saturn[16] = new Body("Iapetus") { Period = 79, Radius = 3561000 };
            saturn[17] = new Body("Phoebe") { Period = -550, Radius = 12952000 };
            sun[5] = saturn;
            solarSystem["Saturn"] = saturn;

            Body uranus = new Body("Uranus") { Period = 30685, Radius = 2870990000, objectRadius = 25362, rotationalPeriod = 17, objectColor = "Blue" };
            uranus[0] = new Body("Cordelia") { Period = 1, Radius = 50000 };
            uranus[1] = new Body("Phelia") { Period = 1, Radius = 54000 };
            uranus[2] = new Body("Bianca") { Period = 1, Radius = 59000 };
            uranus[3] = new Body("Cressida") { Period = 1, Radius = 62000 };
            uranus[4] = new Body("Desdemona") { Period = 1, Radius = 63000 };
            uranus[5] = new Body("Juliet") { Period = 1, Radius = 64000 };
            uranus[6] = new Body("Portia") { Period = 1, Radius = 66000 };
            uranus[7] = new Body("Rosalind") { Period = 1, Radius = 70000 };
            uranus[8] = new Body("Belinda") { Period = 1, Radius = 75000 };
            uranus[9] = new Body("Puck") { Period = 1, Radius = 86000 };
            uranus[10] = new Body("Miranda") { Period = 1, Radius = 130000 };
            uranus[11] = new Body("Ariel") { Period = 3, Radius = 191000 };
            uranus[12] = new Body("Umbriel") { Period = 4, Radius = 266000 };
            uranus[13] = new Body("Titania") { Period = 9, Radius = 436000 };
            uranus[14] = new Body("Oberon") { Period = 13, Radius = 583000 };
            uranus[15] = new Body("Caliban") { Period = -580, Radius = 7169000 };
            uranus[16] = new Body("Stephano") { Period = -674, Radius = 7948000 };
            uranus[17] = new Body("Sycorax") { Period = -1289, Radius = 12213000 };
            uranus[18] = new Body("Prospero") { Period = -2019, Radius = 16568000 };
            uranus[19] = new Body("Setebos") { Period = -2239, Radius = 17681000 };
            sun[6] = uranus;
            solarSystem["Uranus"] = uranus;

            Body neptune = new Body("Neptune") { Period = 60190, Radius = 4504300000, objectRadius = 24622, rotationalPeriod = 16, objectColor = "Blue" };
            neptune[0] = new Body("Naiad") { Period = 1, Radius = 48000 };
            neptune[1] = new Body("Thalassa") { Period = 1, Radius = 50000 };
            neptune[2] = new Body("Despina") { Period = 1, Radius = 53000 };
            neptune[3] = new Body("Galatea") { Period = 1, Radius = 62000 };
            neptune[4] = new Body("Larissa") { Period = 1, Radius = 74000 };
            neptune[5] = new Body("Proteus") { Period = 1, Radius = 118000 };
            neptune[6] = new Body("Triton") { Period = -6, Radius = 355000 };
            neptune[7] = new Body("Nereid") { Period = 360, Radius = 5513000 };
            sun[7] = neptune;
            solarSystem["Neptune"] = neptune;

            Body pluto = new Body("Pluto") { Period = 90550, Radius = 5913520000, objectRadius = 1188, rotationalPeriod = 153, objectColor = "Beige" };
            pluto[0] = new Body("Charon") { Period = 6, Radius = 20000 };
            pluto[1] = new Body("Nix") { Period = 25, Radius = 49000 };
            pluto[2] = new Body("Hydra") { Period = 38, Radius = 65000 };
            sun[8] = pluto;
            solarSystem["Pluto"] = pluto;

            PrintWithChildren(sun);

            Boolean exit = false;
            while(exit == false)
            {
            Console.Write("Enter amount of days since time 0 or '-1' to exit program: ");
            int days = int.Parse(Console.ReadLine());

            if(days== -1)
                {
                    exit = true;
                    break;
                }

            Console.Write("Enter planet name, or leave blank for sun and all planets: ");
            String planet = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(planet))
            {
                planet = "Sun";
            }

            if (solarSystem.ContainsKey(planet))
            {
                Body selectedBody = solarSystem[planet];
                var (x, y) = selectedBody.getPosition(days);
                Console.WriteLine($"{selectedBody.Name}: Position at day {days} -> X: {x}, Y: {y}");
            } else
            {
                Console.WriteLine("Planet not found");
            }
            }
            

        }

        

        static void PrintWithChildren(Body x, int level = 0) {

            if (level == 0) {
                Console.WriteLine($"{"Astronomical Body",-20}\tOrbital Velocity");
                Console.WriteLine($"=================\t================");
            }

            StringBuilder padding = new StringBuilder();
            for (int i = 0; i < level; i++) { padding.Append("  "); }
            Console.WriteLine($"{padding.ToString() + x.Name,-20}\t{x.Velocity,10:F2} km/day");


            // Current implementation don't allow me to fetch the actual list of children
            // I only have access to the indexer, which is why I used this less-than
            // optimal solution here.
            // Obviously, I could just have exposed the array directly through a property,
            // but I kept it this way to focus on the indexer. We'll explore better options
            // later in the course.
            for (int i = 0; i < 100; i++) {
                if (x[i] != null) {
                    PrintWithChildren(x[i], level + 1);
                } else {
                    break;
                }
            }


        }
        
        

        

    }
}
