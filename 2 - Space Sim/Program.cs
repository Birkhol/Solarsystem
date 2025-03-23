using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.Encodings.Web;
using System.Xml.Serialization;
using SpaceSim;
using static SpaceSim.SpaceObject;

class Astronomy {
    public static void Main() {

        // The sun
        Star sun = new Star("Sun", 648, 695000, "Yellow");

        // Mercury #1
        Planet mercury = new Planet("Mercury", 88, 57910000, 2440, 548, "Gray");

        // Venus #2
        Planet venus = new Planet("Venus", 225, 108200000, 6051, 5832, "Orange");

        // Earth and its moon #3
        Planet terra = new Planet("Terra", 365, 150000000, 6378, 24, "Blue");
        Moon moon = new Moon("The Moon", 28, 384000, 1737, "Gray");
        terra.Moons.Add(moon);

        // Mars and its moons #4
        Planet mars = new Planet("Mars", 687, 227940000, 3389, 25, "Red");
        Moon phobos = new Moon("Phobos", 0.32, 9377, 11, "Gray");
        Moon deimos = new Moon("Deimos", 1.26, 23460, 6, "Gray");
        mars.Moons.Add(phobos);
        mars.Moons.Add(deimos);

        // Jupiter and its moons #5
        Planet jupiter = new Planet("Jupiter", 4333, 778330000, 69911, 10, "Beige");
        Moon metis = new Moon("Metis", 0.29, 128000, 22, "Gray");
        Moon adrastea = new Moon("Adrastea", 0.3, 129000, 8, "Gray");
        Moon amalthea = new Moon("Amalthea", 0.5, 181000, 83, "Gray");
        Moon thebe = new Moon("Thebe", 0.67, 222000, 49, "Gray");
        Moon io = new Moon("Io", 1.77, 422000, 1821, "Yellow");
        Moon europa = new Moon("Europa", 3.55, 671000, 1560, "Orange");
        Moon ganymede = new Moon("Ganymede", 7.15, 1070000, 2631, "Gray");
        Moon callisto = new Moon("Callisto", 16.69, 1883000, 2410, "Gray");
        Moon leda = new Moon("Leda", 238, 11094000, 10, "Yellow");
        Moon himalia = new Moon("Himalia", 250, 11480000, 85, "Gray");
        Moon lysithea = new Moon("Lysithea", 259, 11720000, 18, "Gray");
        Moon elara = new Moon("Elara", 259, 11737000, 43, "Gray");
        Moon ananke = new Moon("Ananke", -631, 21200000, 14, "Gray");
        Moon carme = new Moon("Carme", -692, 22600000, 23, "Gray");
        Moon pasiphae = new Moon("Pasiphae", -735, 23500000, 20, "Gray");
        Moon sinope = new Moon("Sinope", -758, 23700000, 19, "Gray");
        jupiter.Moons.Add(metis);
        jupiter.Moons.Add(adrastea);
        jupiter.Moons.Add(amalthea);
        jupiter.Moons.Add(thebe);
        jupiter.Moons.Add(io);
        jupiter.Moons.Add(europa);
        jupiter.Moons.Add(ganymede);
        jupiter.Moons.Add(callisto);
        jupiter.Moons.Add(leda);
        jupiter.Moons.Add(himalia);
        jupiter.Moons.Add(lysithea);
        jupiter.Moons.Add(elara);
        jupiter.Moons.Add(ananke);
        jupiter.Moons.Add(carme);
        jupiter.Moons.Add(pasiphae);
        jupiter.Moons.Add(sinope);

        // Saturn and its moons
        Planet saturn = new Planet("Saturn", 10760, 1429400000, 58232, 11, "Latte");
        Moon pan = new Moon("Pan", 0.58, 134000, 14, "Gray");
        Moon atlas = new Moon("Atlas", 0.6, 138000, 15, "Gray");
        Moon prometheus = new Moon("Prometheus", 0.61, 139000, 43, "Gray");
        Moon pandora = new Moon("Pandora", 0.63, 142000, 40, "Gray");
        Moon janus = new Moon("Janus", 0.69, 150050, 89, "Gray");
        Moon epimetheus = new Moon("Epimetheus", 0.69, 151000, 58, "Gray");
        Moon mimas = new Moon("Mimas", 0.94, 186000, 198, "Gray");
        Moon enceladus = new Moon("Enceladus", 1.37, 238000, 252, "White");
        Moon tethys = new Moon("Tethys", 1.89, 295000, 531, "White");
        Moon telesto = new Moon("Telesto", 1.89, 295000, 12, "Gray");
        Moon calypso = new Moon("Calypso", 1.89, 295000, 11, "Gray");
        Moon dione = new Moon("Dione", 2.74, 377000, 561, "Gray");
        Moon helene = new Moon("Helene", 2.74, 377000, 18, "Gray");
        Moon rhea = new Moon("Rhea", 4.52, 527000, 763, "Gray");
        Moon titan = new Moon("Titan", 15.95, 1222000, 2574, "Yellow");
        Moon hyperion = new Moon("Hyperion", 21.28, 1481000, 135, "Gray");
        Moon iapetus = new Moon("Iapetus", 79.33, 3561000, 734, "Gray");
        Moon phoebe = new Moon("Phoebe", -550, 12952000, 106, "Gray");
        saturn.Moons.Add(pan);
        saturn.Moons.Add(atlas);
        saturn.Moons.Add(prometheus);
        saturn.Moons.Add(pandora);
        saturn.Moons.Add(janus);
        saturn.Moons.Add(epimetheus);
        saturn.Moons.Add(mimas);
        saturn.Moons.Add(enceladus);
        saturn.Moons.Add(tethys);
        saturn.Moons.Add(telesto);
        saturn.Moons.Add(calypso);
        saturn.Moons.Add(dione);
        saturn.Moons.Add(helene);
        saturn.Moons.Add(rhea);
        saturn.Moons.Add(titan);
        saturn.Moons.Add(hyperion);
        saturn.Moons.Add(iapetus);
        saturn.Moons.Add(phoebe);

        // Uranus and its moons
        Planet uranus = new Planet("Uranus", 30685, 2870990000, 25362, 17, "Blue");
        Moon cordelia = new Moon("Cordelia", 0.34, 50000, 20, "Gray");
        Moon ophelia = new Moon("Ophelia", 0.38, 54000, 21, "Gray");
        Moon bianca = new Moon("Bianca", 0.43, 59000, 27, "Gray");
        Moon cressida = new Moon("Cressida", 0.46, 62000, 40, "Gray");
        Moon desdemona = new Moon("Desdemona", 0.47, 63000, 32, "Gray");
        Moon juliet = new Moon("Juliet", 0.49, 64000, 47, "Gray");
        Moon portia = new Moon("Portia", 0.51, 66000, 68, "Gray");
        Moon rosalind = new Moon("Rosalind", 0.56, 70000, 36, "Gray");
        Moon belinda = new Moon("Belinda", 0.62, 75000, 40, "Gray");
        Moon puck = new Moon("Puck", 0.76, 86000, 81, "Gray");
        Moon miranda = new Moon("Miranda", 1.41, 130000, 235, "Gray");
        Moon ariel = new Moon("Ariel", 2.52, 191000, 578, "Gray");
        Moon umbriel = new Moon("Umbriel", 4.14, 266000, 585, "Gray");
        Moon titania = new Moon("Titania", 8.71, 436000, 788, "Gray");
        Moon oberon = new Moon("Oberon", 13.46, 583000, 761, "Gray");
        Moon caliban = new Moon("Caliban", -580, 7169000, 36, "Gray");
        Moon stephano = new Moon("Stephano", -674, 7948000, 16, "Gray");
        Moon sycorax = new Moon("Sycorax", -1289, 12213000, 75, "Gray");
        Moon prospero = new Moon("Prospero", -2019, 16568000, 25, "Gray");
        Moon setebos = new Moon("Setebos", -2239, 17681000, 24, "Gray");
        uranus.Moons.Add(cordelia);
        uranus.Moons.Add(ophelia);
        uranus.Moons.Add(bianca);
        uranus.Moons.Add(cressida);
        uranus.Moons.Add(desdemona);
        uranus.Moons.Add(juliet);
        uranus.Moons.Add(portia);
        uranus.Moons.Add(rosalind);
        uranus.Moons.Add(belinda);
        uranus.Moons.Add(puck);
        uranus.Moons.Add(miranda);
        uranus.Moons.Add(ariel);
        uranus.Moons.Add(umbriel);
        uranus.Moons.Add(titania);
        uranus.Moons.Add(oberon);
        uranus.Moons.Add(caliban);
        uranus.Moons.Add(stephano);
        uranus.Moons.Add(sycorax);
        uranus.Moons.Add(prospero);
        uranus.Moons.Add(setebos);

        // Neptune and its moons
        Planet neptune = new Planet("Neptune", 60190, 4504300000, 24622, 16, "Blue");
        Moon naiad = new Moon("Naiad", 0.29, 48000, 33, "Gray");
        Moon thalassa = new Moon("Thalassa", 0.31, 50000, 41, "Gray");
        Moon despina = new Moon("Despina", 0.33, 53000, 75, "Gray");
        Moon galatea = new Moon("Galatea", 0.43, 62000, 87, "Gray");
        Moon larissa = new Moon("Larissa", 0.55, 74000, 97, "Gray");
        Moon proteus = new Moon("Proteus", 1.12, 118000, 210, "Gray");
        Moon triton = new Moon("Triton", -5.88, 355000, 1353, "Gray");
        Moon nereid = new Moon("Nereid", 360, 5513000, 170, "Gray");
        neptune.Moons.Add(naiad);
        neptune.Moons.Add(thalassa);
        neptune.Moons.Add(despina);
        neptune.Moons.Add(galatea);
        neptune.Moons.Add(larissa);
        neptune.Moons.Add(proteus);
        neptune.Moons.Add(triton);
        neptune.Moons.Add(nereid);

        // Pluto and its moons
        DwarfPlanet pluto = new DwarfPlanet("Pluto", 90550, 5913520000, 1188, 153, "Beige");
        Moon charon = new Moon("Charon", 6.39, 20000, 606, "Gray");
        Moon nix = new Moon("Nix", 24.86, 49000, 25, "Gray");
        Moon hydra = new Moon("Hydra", 38.21, 65000, 26, "Gray");
        pluto.Moons.Add(charon);
        pluto.Moons.Add(nix);
        pluto.Moons.Add(hydra);


        List<SpaceObject> solarSystem = new List<SpaceObject>
        {

            sun, mercury, venus, terra, mars, jupiter, saturn, uranus, neptune, pluto

        };

        List<Planet> planets = new List<Planet>
        {
            mercury, venus, terra, mars, jupiter, saturn, uranus, neptune
        };

        foreach (var s in planets) {
            s.Draw();
        }

        Boolean exit = false;
        while (exit == false)
        {
        Console.WriteLine("Enter name of a planet, type 'exit' to quit");
        string planetName = Console.ReadLine();

        if (planetName.Equals("exit"))
            {
                exit = true;
                break;
            }

        Planet selectedPlanet = planets.Find(x => x.Name.Equals(planetName));
        

        Console.WriteLine("Enter amount of days");
        int days = int.Parse(Console.ReadLine());

        var planetPosition = selectedPlanet.GetPosition(days);
        Console.WriteLine($"{selectedPlanet.Name}: Position at day {days} -> X: {planetPosition.X}, Y: {planetPosition.Y}");
            
        if (string.IsNullOrWhiteSpace(planetName))
        {
            foreach (var o in solarSystem)
            {
                var (x, y) = o.GetPosition(days);
                Console.WriteLine($"{o.Name}: Position at day {days} -> X: {x}, Y: {y}");
            }
        }

        foreach (var m in selectedPlanet.Moons)
        {
            var moonPosition = m.GetMoonPosition(days, moon);
            Console.WriteLine($"{m.Name}'s Position after {days} days: X = {moonPosition.a + planetPosition.X}, Y = {moonPosition.b + planetPosition.Y}");
        }

        
        }

        
    }

}

