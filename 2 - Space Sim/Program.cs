using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.Encodings.Web;
using SpaceSim;

class Astronomy {
    public static void Main() {

        // The sun
        Star sun = new Star("Sun", 648, 695000, "Yellow");

        // Mercury #1
        Planet mercury = new Planet("Mercury", 88, 57910000, 2440, 548, "Grey");

        // Venus #2
        Planet venus = new Planet("Venus", 225, 108200000, 6051, 5832, "Orange");

        // Earth and its moon #3
        Planet terra = new Planet("Terra", 365, 150000000, 6378, 24, "Blue");
        Moon moon = new Moon("The Moon", 28, 384000, 1737, "Grey");
        terra.Moons.Add(moon);

        // Mars and its moons #4
        Planet mars = new Planet("Mars", 687, 227940000, 3389, 25, "Red");
        Moon phobos = new Moon("Phobos", 0.32, 9377, 11267, "Grey");
        Moon deimos = new Moon("Deimos", 1.26, 23460, 6, "Grey");
        mars.Moons.Add(phobos);
        mars.Moons.Add(deimos);

        // Jupiter and its moons #5
        Planet jupiter = new Planet("Jupiter", 4333, 778330000, 69911, 10, "Beige");
        Moon metis = new Moon("Metis", 0.29, 128000, 22, "Grey");
        Moon adrastea = new Moon("Adrastea", 0.3, 129000, 8, "Grey");
        Moon amalthea = new Moon("Amalthea", 0.5, 181000, 83, "Grey");
        Moon thebe = new Moon("Thebe", 0.67, 222000, 49, "Grey");
        Moon io = new Moon("Io", 1.77, 422000, 1821, "Yellow");
        Moon europa = new Moon("Europa", 3.55, 671000, 1560, "Orange");
        Moon ganymede = new Moon("Ganymede", 7.15, 1070000, 2631, "Grey");
        Moon callisto = new Moon("Callisto", 16.69, 1883000, 2410, "Grey");
        Moon leda = new Moon("Leda", 238, 11094000, 10, "Yellow");
        Moon himalia = new Moon("Himalia", 250, 11480000, 85, "Grey");
        Moon lysithea = new Moon("Lysithea", 259, 11720000, 18, "Grey");
        Moon elara = new Moon("Elara", 259, 11737000, 43, "Grey");
        Moon ananke = new Moon("Ananke", -631, 21200000, 14, "Grey");
        Moon carme = new Moon("Carme", -692, 22600000, 23, "Grey");
        Moon pasiphae = new Moon("Pasiphae", -735, 23500000, 20, "Grey");
        Moon sinope = new Moon("Sinope", -758, 23700000, 19, "Grey");
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
        Moon pan = new Moon("Pan", 0.58, 134000, 14, "Grey");
        Moon atlas = new Moon("Atlas", 0.6, 138000, 15, "Grey");
        Moon prometheus = new Moon("Prometheus", 0.61, 139000, 43, "Grey");
        Moon pandora = new Moon("Pandora", 0.63, 142000, 40, "Grey");
        Moon janus = new Moon("Janus", 0.69, 150050, 89, "Grey");
        Moon epimetheus = new Moon("Epimetheus", 0.69, 151000, 58, "Grey");
        Moon mimas = new Moon("Mimas", 0.94, 186000, 198, "Grey");
        Moon enceladus = new Moon("Enceladus", 1.37, 238000, 252, "White");
        Moon tethys = new Moon("Tethys", 1.89, 295000, 531, "White");
        Moon telesto = new Moon("Telesto", 1.89, 295000, 12, "Grey");
        Moon calypso = new Moon("Calypso", 1.89, 295000, 11, "Grey");
        Moon dione = new Moon("Dione", 2.74, 377000, 561, "Grey");
        Moon helene = new Moon("Helene", 2.74, 377000, 18, "Grey");
        Moon rhea = new Moon("Rhea", 4.52, 527000, 763, "Grey");
        Moon titan = new Moon("Titan", 15.95, 1222000, 2574, "Yellow");
        Moon hyperion = new Moon("Hyperion", 21.28, 1481000, 135, "Grey");
        Moon iapetus = new Moon("Iapetus", 79.33, 3561000, 734, "Grey");
        Moon phoebe = new Moon("Phoebe", -550, 12952000, 106, "Grey");
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
        Moon cordelia = new Moon("Cordelia", 0.34, 50000, 20, "Grey");
        Moon ophelia = new Moon("Ophelia", 0.38, 54000, 21, "Grey");
        Moon bianca = new Moon("Bianca", 0.43, 59000, 27, "Grey");
        Moon cressida = new Moon("Cressida", 0.46, 62000, 40, "Grey");
        Moon desdemona = new Moon("Desdemona", 0.47, 63000, 32, "Grey");
        Moon juliet = new Moon("Juliet", 0.49, 64000, 47, "Grey");
        Moon portia = new Moon("Portia", 0.51, 66000, 68, "Grey");
        Moon rosalind = new Moon("Rosalind", 0.56, 70000, 36, "Grey");
        Moon belinda = new Moon("Belinda", 0.62, 75000, 40, "Grey");
        Moon puck = new Moon("Puck", 0.76, 86000, 81, "Grey");
        Moon miranda = new Moon("Miranda", 1.41, 130000, 235, "Grey");
        Moon ariel = new Moon("Ariel", 2.52, 191000, 578, "Grey");
        Moon umbriel = new Moon("Umbriel", 4.14, 266000, 585, "Grey");
        Moon titania = new Moon("Titania", 8.71, 436000, 788, "Grey");
        Moon oberon = new Moon("Oberon", 13.46, 583000, 761, "Grey");
        Moon caliban = new Moon("Caliban", -580, 7169000, 36, "Grey");
        Moon stephano = new Moon("Stephano", -674, 7948000, 16, "Grey");
        Moon sycorax = new Moon("Sycorax", -1289, 12213000, 75, "Grey");
        Moon prospero = new Moon("Prospero", -2019, 16568000, 25, "Grey");
        Moon setebos = new Moon("Setebos", -2239, 17681000, 24, "Grey");
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
        Moon naiad = new Moon("Naiad", 0.29, 48000, 33, "Grey");
        Moon thalassa = new Moon("Thalassa", 0.31, 50000, 41, "Grey");
        Moon despina = new Moon("Despina", 0.33, 53000, 75, "Grey");
        Moon galatea = new Moon("Galatea", 0.43, 62000, 87, "Grey");
        Moon larissa = new Moon("Larissa", 0.55, 74000, 97, "Grey");
        Moon proteus = new Moon("Proteus", 1.12, 118000, 210, "Grey");
        Moon triton = new Moon("Triton", -5.88, 355000, 1353, "Grey");
        Moon nereid = new Moon("Nereid", 360, 5513000, 170, "Grey");
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
        Moon charon = new Moon("Charon", 6.39, 20000, 606, "Grey");
        Moon nix = new Moon("Nix", 24.86, 49000, 25, "Grey");
        Moon hydra = new Moon("Hydra", 38.21, 65000, 26, "Grey");
        pluto.Moons.Add(charon);
        pluto.Moons.Add(nix);
        pluto.Moons.Add(hydra);


        List<SpaceObject> solarSystem = new List<SpaceObject>
        {

            sun, mercury, venus, terra, mars, jupiter, saturn, uranus, neptune, pluto,

        };

        foreach (var s in solarSystem) {
            s.Draw();
        }

    }
}

