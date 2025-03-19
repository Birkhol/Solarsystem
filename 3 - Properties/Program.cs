using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Text;
using System.Xml.Serialization;


namespace Properties
{
    class Program
    {
        static void Main()
        {

            Dictionary<string, Body> solarSystem = new Dictionary<string, Body>();

            // Standard traditional syntax
            Body sun = new Body("Sol");
            sun.Radius = 0;
            sun.Period = 0;
            sun.objectRadius = 695000;
            sun.rotationalPeriod = 648;
            sun.objectColor = "Yellow";
            solarSystem["SUN"] = sun;

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
            solarSystem["EARTH"] = earth;

            // Adding the moon to earth
            Body moon = new("The Moon") { Period = 28, Radius = 384000, objectRadius = 1737, rotationalPeriod = 648, objectColor = "Gray" };
            earth[0] = moon;
            solarSystem["MOON"] = moon;

            // Mercury
            Body mercury = new Body("Mercury") { Period = 88, Radius = 57910000, objectRadius = 2440, rotationalPeriod = 1416, objectColor = "Gray" };
            sun[0] = mercury;
            solarSystem["MERCURY"] = mercury;

            // Venus
            Body venus = new Body("Venus") { Period = 225, Radius = 108200000, objectRadius = 6051, rotationalPeriod = 5832, objectColor = "Orange" };
            sun[1] = venus;
            solarSystem["VENUS"] = venus;

            // Mars and its moons
            Body mars = new Body("Mars") { Period = 687, Radius = 227940000, objectRadius = 3389, rotationalPeriod = 25, objectColor = "Red" };
            sun[3] = mars;
            solarSystem["MARS"] = mars;

            Body phobos = new Body("Phobos") { Period = 8, Radius = 9377 };
            mars[0] = phobos;
            solarSystem["PHOBOS"] = phobos;

            Body deimos = new Body("Deimos") { Period = 30, Radius = 23460 };
            mars[1] = deimos;
            solarSystem["DEIMOS"] = deimos;



            // Jupiter and its moons
            Body jupiter = new Body("Jupiter") { Period = 4333, Radius = 778330000, objectRadius = 69911, rotationalPeriod = 10, objectColor = "Beige" };
            sun[4] = jupiter;
            solarSystem["JUPITER"] = jupiter;

            Body metis = new Body("Metis") { Period = 1, Radius = 128000 };
            jupiter[0] = metis;
            solarSystem["METIS"] = metis;

            Body adrastea = new Body("Adrastea") { Period = 1, Radius = 129000 };
            jupiter[1] = adrastea;
            solarSystem["ADRASTEA"] = adrastea;

            Body amalthea = new Body("Amalthea") { Period = 1, Radius = 181000 };
            jupiter[2] = amalthea;
            solarSystem["AMALTHEA"] = amalthea;

            Body thebe = new Body("Thebe") { Period = 1, Radius = 222000 };
            jupiter[3] = thebe;
            solarSystem["THEBE"] = thebe;

            Body io = new Body("Io") { Period = 2, Radius = 422000 };
            jupiter[4] = io;
            solarSystem["IO"] = io;

            Body europa = new Body("Europa") { Period = 4, Radius = 671000 };
            jupiter[5] = europa;
            solarSystem["EUROPA"] = europa;

            Body ganymede = new Body("Ganymede") { Period = 7, Radius = 1070000 };
            jupiter[6] = ganymede;
            solarSystem["GANYMEDE"] = ganymede;

            Body callisto = new Body("Callisto") { Period = 17, Radius = 1883000 };
            jupiter[7] = callisto;
            solarSystem["CALLISTO"] = callisto;

            Body leda = new Body("Leda") { Period = 239, Radius = 11094000 };
            jupiter[8] = leda;
            solarSystem["LEDA"] = leda;

            Body himalia = new Body("Himalia") { Period = 251, Radius = 11480000 };
            jupiter[9] = himalia;
            solarSystem["HIMALIA"] = himalia;

            Body lysithea = new Body("Lysithea") { Period = 259, Radius = 11720000 };
            jupiter[10] = lysithea;
            solarSystem["LYSITHEA"] = lysithea;

            Body elara = new Body("Elara") { Period = 260, Radius = 11737000 };
            jupiter[11] = elara;
            solarSystem["ELARA"] = elara;

            Body ananke = new Body("Ananke") { Period = -631, Radius = 21200000 };
            jupiter[12] = ananke;
            solarSystem["ANANKE"] = ananke;

            Body carme = new Body("Carme") { Period = -692, Radius = 22600000 };
            jupiter[13] = carme;
            solarSystem["CARME"] = carme;

            Body pasiphae = new Body("Pasiphae") { Period = -735, Radius = 23500000 };
            jupiter[14] = pasiphae;
            solarSystem["PASIPHAE"] = pasiphae;

            Body sinope = new Body("Sinope") { Period = -758, Radius = 23700000 };
            jupiter[15] = sinope;
            solarSystem["SINOPE"] = sinope;



            // Saturn and its moons
            Body saturn = new Body("Saturn") { Period = 10760, Radius = 1429400000, objectRadius = 58232, rotationalPeriod = 11, objectColor = "Latte" };
            sun[5] = saturn;
            solarSystem["SATURN"] = saturn;

            Body pan = new Body("Pan") { Period = 1, Radius = 134000 };
            saturn[0] = pan;
            solarSystem["PAN"] = pan;

            Body atlas = new Body("Atlas") { Period = 1, Radius = 138000 };
            saturn[1] = atlas;
            solarSystem["ATLAS"] = atlas;

            Body prometheus = new Body("Prometheus") { Period = 1, Radius = 139000 };
            saturn[2] = prometheus;
            solarSystem["PROMETHEUS"] = prometheus;

            Body pandora = new Body("Pandora") { Period = 1, Radius = 142000 };
            saturn[3] = pandora;
            solarSystem["PANDORA"] = pandora;

            Body epimetheus = new Body("Epimetheus") { Period = 1, Radius = 151000 };
            saturn[4] = epimetheus;
            solarSystem["EPIMETHEUS"] = epimetheus;

            Body janus = new Body("Janus") { Period = 1, Radius = 151000 };
            saturn[5] = janus;
            solarSystem["JANUS"] = janus;

            Body mimas = new Body("Mimas") { Period = 1, Radius = 186000 };
            saturn[6] = mimas;
            solarSystem["MIMAS"] = mimas;

            Body enceladus = new Body("Enceladus") { Period = 1, Radius = 238000 };
            saturn[7] = enceladus;
            solarSystem["ENCELADUS"] = enceladus;

            Body tethys = new Body("Tethys") { Period = 2, Radius = 295000 };
            saturn[8] = tethys;
            solarSystem["TETHYS"] = tethys;

            Body telesto = new Body("Telesto") { Period = 2, Radius = 295000 };
            saturn[9] = telesto;
            solarSystem["TELESTO"] = telesto;

            Body calypso = new Body("Calypso") { Period = 2, Radius = 295000 };
            saturn[10] = calypso;
            solarSystem["CALYPSO"] = calypso;

            Body dione = new Body("Dione") { Period = 3, Radius = 377000 };
            saturn[11] = dione;
            solarSystem["DIONE"] = dione;

            Body helene = new Body("Helene") { Period = 3, Radius = 377000 };
            saturn[12] = helene;
            solarSystem["HELENE"] = helene;

            Body rhea = new Body("Rhea") { Period = 5, Radius = 527000 };
            saturn[13] = rhea;
            solarSystem["RHEA"] = rhea;

            Body titan = new Body("Titan") { Period = 16, Radius = 1222000 };
            saturn[14] = titan;
            solarSystem["TITAN"] = titan;

            Body hyperion = new Body("Hyperion") { Period = 21, Radius = 1481000 };
            saturn[15] = hyperion;
            solarSystem["HYPERION"] = hyperion;

            Body iapetus = new Body("Iapetus") { Period = 79, Radius = 3561000 };
            saturn[16] = iapetus;
            solarSystem["IAPETUS"] = iapetus;

            Body phoebe = new Body("Phoebe") { Period = -550, Radius = 12952000 };
            saturn[17] = phoebe;
            solarSystem["PHOEBE"] = phoebe;



            // Uranus and its moons
            Body uranus = new Body("Uranus") { Period = 30685, Radius = 2870990000, objectRadius = 25362, rotationalPeriod = 17, objectColor = "Blue" };
            sun[6] = uranus;
            solarSystem["URANUS"] = uranus;

            Body cordelia = new Body("Cordelia") { Period = 1, Radius = 50000 };
            uranus[0] = cordelia;
            solarSystem["CORDELIA"] = cordelia;

            Body phelia = new Body("Phelia") { Period = 1, Radius = 54000 };
            uranus[1] = phelia;
            solarSystem["PHELIA"] = phelia;

            Body bianca = new Body("Bianca") { Period = 1, Radius = 59000 };
            uranus[2] = bianca;
            solarSystem["BIANCA"] = bianca;

            Body cressida = new Body("Cressida") { Period = 1, Radius = 62000 };
            uranus[3] = cressida;
            solarSystem["CRESSIDA"] = cressida;

            Body desdemona = new Body("Desdemona") { Period = 1, Radius = 63000 };
            uranus[4] = desdemona;
            solarSystem["DESDEMONA"] = desdemona;

            Body juliet = new Body("Juliet") { Period = 1, Radius = 64000 };
            uranus[5] = juliet;
            solarSystem["JULIET"] = juliet;

            Body portia = new Body("Portia") { Period = 1, Radius = 66000 };
            uranus[6] = portia;
            solarSystem["PORTIA"] = portia;

            Body rosalind = new Body("Rosalind") { Period = 1, Radius = 70000 };
            uranus[7] = rosalind;
            solarSystem["ROSALIND"] = rosalind;

            Body belinda = new Body("Belinda") { Period = 1, Radius = 75000 };
            uranus[8] = belinda;
            solarSystem["BELINDA"] = belinda;

            Body puck = new Body("Puck") { Period = 1, Radius = 86000 };
            uranus[9] = puck;
            solarSystem["PUCK"] = puck;

            Body miranda = new Body("Miranda") { Period = 1, Radius = 130000 };
            uranus[10] = miranda;
            solarSystem["MIRANDA"] = miranda;

            Body ariel = new Body("Ariel") { Period = 3, Radius = 191000 };
            uranus[11] = ariel;
            solarSystem["ARIEL"] = ariel;

            Body umbriel = new Body("Umbriel") { Period = 4, Radius = 266000 };
            uranus[12] = umbriel;
            solarSystem["UMBRIEL"] = umbriel;

            Body titania = new Body("Titania") { Period = 9, Radius = 436000 };
            uranus[13] = titania;
            solarSystem["TITANIA"] = titania;

            Body oberon = new Body("Oberon") { Period = 13, Radius = 583000 };
            uranus[14] = oberon;
            solarSystem["OBERON"] = oberon;

            Body caliban = new Body("Caliban") { Period = -580, Radius = 7169000 };
            uranus[15] = caliban;
            solarSystem["CALIBAN"] = caliban;

            Body stephano = new Body("Stephano") { Period = -674, Radius = 7948000 };
            uranus[16] = stephano;
            solarSystem["STEPHANO"] = stephano;

            Body sycorax = new Body("Sycorax") { Period = -1289, Radius = 12213000 };
            uranus[17] = sycorax;
            solarSystem["SYCORAX"] = sycorax;

            Body prospero = new Body("Prospero") { Period = -2019, Radius = 16568000 };
            uranus[18] = prospero;
            solarSystem["PROSPERO"] = prospero;

            Body setebos = new Body("Setebos") { Period = -2239, Radius = 17681000 };
            uranus[19] = setebos;
            solarSystem["SETEBOS"] = setebos;



            // Neptune and its moons
            Body neptune = new Body("Neptune") { Period = 60190, Radius = 4504300000, objectRadius = 24622, rotationalPeriod = 16, objectColor = "Blue" };
            sun[7] = neptune;
            solarSystem["NEPTUNE"] = neptune;

            Body naiad = new Body("Naiad") { Period = 1, Radius = 48000 };
            neptune[0] = naiad;
            solarSystem["NAIAD"] = naiad;

            Body thalassa = new Body("Thalassa") { Period = 1, Radius = 50000 };
            neptune[1] = thalassa;
            solarSystem["THALASSA"] = thalassa;

            Body despina = new Body("Despina") { Period = 1, Radius = 53000 };
            neptune[2] = despina;
            solarSystem["DESPINA"] = despina;

            Body galatea = new Body("Galatea") { Period = 1, Radius = 62000 };
            neptune[3] = galatea;
            solarSystem["GALATEA"] = galatea;

            Body larissa = new Body("Larissa") { Period = 1, Radius = 74000 };
            neptune[4] = larissa;
            solarSystem["LARISSA"] = larissa;

            Body proteus = new Body("Proteus") { Period = 1, Radius = 118000 };
            neptune[5] = proteus;
            solarSystem["PROTEUS"] = proteus;

            Body triton = new Body("Triton") { Period = -6, Radius = 355000 };
            neptune[6] = triton;
            solarSystem["TRITON"] = triton;

            Body nereid = new Body("Nereid") { Period = 360, Radius = 5513000 };
            neptune[7] = nereid;
            solarSystem["NEREID"] = nereid;



            // Pluto and its moons
            Body pluto = new Body("Pluto") { Period = 90550, Radius = 5913520000, objectRadius = 1188, rotationalPeriod = 153, objectColor = "Beige" };
            sun[8] = pluto;
            solarSystem["PLUTO"] = pluto;

            Body charon = new Body("Charon") { Period = 6, Radius = 20000 };
            pluto[0] = charon;
            solarSystem["CHARON"] = charon;

            Body nix = new Body("Nix") { Period = 25, Radius = 49000 };
            pluto[1] = nix;
            solarSystem["NIX"] = nix;

            Body hydra = new Body("Hydra") { Period = 38, Radius = 65000 };
            pluto[2] = hydra;
            solarSystem["HYDRA"] = hydra;




            PrintWithChildren(sun);

            // Ask user for number of days of time, then ask for which planet
            Boolean exit = false;
            while (exit == false)
            {
                Console.Write("Enter amount of days since time 0 or '-1' to exit program: ");
                int days = int.Parse(Console.ReadLine());

                if (days == -1)
                {
                    exit = true;
                    break;
                }

                Console.Write("Enter planet name, or leave blank for sun and all planets: ");
                String planet = Console.ReadLine().ToUpper();

                // If user inputs "Sun" or leaves blank, it will select all units in the solarsystem
                if (string.IsNullOrWhiteSpace(planet))
                {
                    foreach (var body in solarSystem.Values)
                    {
                        var (x, y) = body.getPosition(days);
                        Console.WriteLine($"{body.Name}: Position at day {days} -> X: {x}, Y: {y}");
                    }
                }

                // If userinput correlates to a planet in the solarsystem, prints out its X and Y coordinates at specified #days
                if (solarSystem.ContainsKey(planet))
                {
                    Body selectedBody = solarSystem[planet];
                    var (x, y) = selectedBody.getPosition(days);
                    Console.WriteLine($"{selectedBody.Name}: Position at day {days} -> X: {x}, Y: {y}");
                    foreach (var moons in selectedBody.GetMoons())
                    {
                        var (a, b) = moons.getPosition(days);
                        Console.WriteLine($"{moons.Name}: Position at day {days} -> X: {a}, Y: {b}");
                    }

                }
                else
                {
                    Console.WriteLine("Planet not found");
                }


            }



            static void PrintWithChildren(Body x, int level = 0)
            {

                if (level == 0)
                {
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
                for (int i = 0; i < 100; i++)
                {
                    if (x[i] != null)
                    {
                        PrintWithChildren(x[i], level + 1);
                    }
                    else
                    {
                        break;
                    }
                }


            }
        }
    }
}