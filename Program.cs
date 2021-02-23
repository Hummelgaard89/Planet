using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planet
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Planet> Planets_Info = new List<Planet>();//Her bliver listen til planeterne oprettet og efterfølgende tilføjet.
            //
            //                          Name        Mass        Diameter    Density     Gravity     Rotation    LenghtofDay     DistancetoSun   OrbitalPeriod   OrbitalVelocity MeanTemperature NumberofMoons   RingSystem
            Planets_Info.Add(new Planet("Mercury",  0.330,      4879,       5427,       3.7,        1407.6,     4222.6,         57.9,           88.0,           47.4,           167,            0,              "No"));
            Planets_Info.Add(new Planet("Venus",    4.87,       12104,      5243,       8.9,        -5832.5,    2802.0,         108.2,          224.7,          35.0,           464,            0,              "No"));
            Planets_Info.Add(new Planet("Earth",    5.97,       12756,      5514,       9.8,        23.9,       24.0,           149.6,          365.2,          29.8,           15,             1,              "No")); 
            Planets_Info.Add(new Planet("Mars",     0.642,      6792,       3933,       3.7,        24.6,       24.7,           227.9,          687.0,          24.1,           -65,            2,              "No"));
            Planets_Info.Add(new Planet("Jupiter",  1898,       142984,     1324,       23.1,       9.9,        9.9,            778.6,          4331,           13.1,           -110,           67,             "Yes"));
            Planets_Info.Add(new Planet("Saturn",   568,        120536,     687,        9.0,        10.7,       10.7,           1433.5,         10747,          9.7,            -140,           623,            "Yes"));
            Planets_Info.Add(new Planet("Uranus",   86.3,       51118,      1271,       8.7,        -17.2,      17.2,           2872.5,         30589,          6.8,            -195,           27,             "Yes"));
            Planets_Info.Add(new Planet("Neptune",  102,        49528,      1638,       11.0,       16.1,       16.1,           4495.1,         59.8,           5.4,            -200,           14,             "Yes"));
            Planets_Info.Add(new Planet("Pluto",    0.0146,     2370,       2095,       0.7,        -153.3,     153.3,          5906.4,         90.56,          4.7,            -225,           5,              "No"));
            //Venus bliver indsat på plads nr 2 i rækken så det passer med rækketølgen (plads 1 i listen) hvis man bruger nedestående
            //Planets_Info.Insert(1,(new Planet("Venus", 4.87, 12104, 5243, 8.9, -5832.5, 2802.0, 108.2, 224.7, 35.0, 464, 0, "No")));

            //Her udskriver vi vores liste med planeter.
            foreach (Planet Planet in Planets_Info)
            {
                Console.WriteLine("Name                             " + Planet.planetName);
                Console.WriteLine("Mass (1024kg) =                  " + Planet.planetMass);
                Console.WriteLine("Diameter (kg/m3) =               " + Planet.planetDiameter);
                Console.WriteLine("Density (km) =                   " + Planet.planetDensity);
                Console.WriteLine("Gravity (m/s2) =                 " + Planet.planetGravity);
                Console.WriteLine("Rotation Period(Hours) =         " + Planet.planetRotationPeriod);
                Console.WriteLine("Lenght of Day (Hours) =          " + Planet.planetLengthOfDay);
                Console.WriteLine("Distance from Sun (106km) =      " + Planet.planetDistanceToSun);
                Console.WriteLine("Orbital Period (days) =          " + Planet.planetOrbitalPeriod);
                Console.WriteLine("Orbital Velocity (km/s) =        " + Planet.planetOrbitalVelocity);
                Console.WriteLine("Mean Temperature (C) =           " + Planet.planetMeanTemperature);
                Console.WriteLine("Number of Moons =                " + Planet.planetNumberOfMoons);
                Console.WriteLine("Ringsystem? =                    " + Planet.planetRingSystem);
                Console.WriteLine("\n\n");
            }
            Console.ReadLine();
            //

            //Denne forløkke kigger efter "Pluto" som Planet Navn og tæller samtidig objekterne, når den finder "Pluto" sletter den objektet på den pågældende plads.
            for (int i = Planets_Info.Count-1; i>=0; i--)
            {
                if (Planets_Info[i].planetName == "Pluto")
                {
                    Planets_Info.RemoveAt(i);
                }
            }
            //

            //Her udskriver vi igen listen over planeter, nu uden Pluto.
            foreach (Planet Planet in Planets_Info)
            {
                Console.WriteLine("Name                             " + Planet.planetName);
                Console.WriteLine("Mass (1024kg) =                  " + Planet.planetMass);
                Console.WriteLine("Diameter (kg/m3) =               " + Planet.planetDiameter);
                Console.WriteLine("Density (km) =                   " + Planet.planetDensity);
                Console.WriteLine("Gravity (m/s2) =                 " + Planet.planetGravity);
                Console.WriteLine("Rotation Period(Hours) =         " + Planet.planetRotationPeriod);
                Console.WriteLine("Lenght of Day (Hours) =          " + Planet.planetLengthOfDay);
                Console.WriteLine("Distance from Sun (106km) =      " + Planet.planetDistanceToSun);
                Console.WriteLine("Orbital Period (days) =          " + Planet.planetOrbitalPeriod);
                Console.WriteLine("Orbital Velocity (km/s) =        " + Planet.planetOrbitalVelocity);
                Console.WriteLine("Mean Temperature (C) =           " + Planet.planetMeanTemperature);
                Console.WriteLine("Number of Moons =                " + Planet.planetNumberOfMoons);
                Console.WriteLine("Ringsystem? =                    " + Planet.planetRingSystem);
                Console.WriteLine("\n\n");
            }
            Console.ReadLine();
            //

            //Her bliver Pluto tilføjet igen og lægger sig bagerst i rækken.
            Planets_Info.Add(new Planet("Pluto", 0.0146, 2370, 2095, 0.7, -153.3, 153.3, 5906.4, 90.56, 4.7, -225, 5, "No"));
            //Her udskrives antallet af objekter i listen "Planets_Info"
            Console.WriteLine("Number of planets = " + Planets_Info.Count);
            Console.ReadLine();
            //

            //Her ledes der efter planeter med en Mean Temperatur under 0 og tilføjer dem til en ny liste ved navn Mean_Planets
            List<Planet> Mean_Planets = new List<Planet>();
            for (int i = Planets_Info.Count - 1; i >= 0; i--)
            {
                if (Planets_Info[i].planetMeanTemperature < 0)
                {
                    Mean_Planets.Add(Planets_Info[i]);
                }
            }
            //Vender rækkefølgen af planeterne i Mean_Planets så rækkefølgen stemmer over ens med Planets_Info
            Mean_Planets.Reverse();
            //Her udskrives Mean_Planets Listen
            foreach (Planet Planet in Mean_Planets)
            {
                Console.WriteLine("Name                             " + Planet.planetName);
                Console.WriteLine("Mass (1024kg) =                  " + Planet.planetMass);
                Console.WriteLine("Diameter (kg/m3) =               " + Planet.planetDiameter);
                Console.WriteLine("Density (km) =                   " + Planet.planetDensity);
                Console.WriteLine("Gravity (m/s2) =                 " + Planet.planetGravity);
                Console.WriteLine("Rotation Period(Hours) =         " + Planet.planetRotationPeriod);
                Console.WriteLine("Lenght of Day (Hours) =          " + Planet.planetLengthOfDay);
                Console.WriteLine("Distance from Sun (106km) =      " + Planet.planetDistanceToSun);
                Console.WriteLine("Orbital Period (days) =          " + Planet.planetOrbitalPeriod);
                Console.WriteLine("Orbital Velocity (km/s) =        " + Planet.planetOrbitalVelocity);
                Console.WriteLine("Mean Temperature (C) =           " + Planet.planetMeanTemperature);
                Console.WriteLine("Number of Moons =                " + Planet.planetNumberOfMoons);
                Console.WriteLine("Ringsystem? =                    " + Planet.planetRingSystem);
                Console.WriteLine("\n\n");
            }
            Console.ReadLine();
            //

            //Her ledes der efter planeter med en diameter over 10000 men under 50000 og tilføjer til listen Medidum_Planets
            List<Planet> Medium_Planets = new List<Planet>();
            for (int i = Planets_Info.Count - 1; i >= 0; i--)
            {
                if (Planets_Info[i].planetDiameter > 10000 && Planets_Info[i].planetDiameter < 50000)
                {
                    Medium_Planets.Add(Planets_Info[i]);
                }
            }
            //Vender rækkefølgen af planeterne i Medium_Planets så rækkefølgen stemmer over ens med Planets_Info
            Medium_Planets.Reverse();
            Console.WriteLine("Medium Planets \n\n");
            //Her udskrives Medium_Planets Listen
            foreach (Planet Planet in Medium_Planets)
            {
                Console.WriteLine("Name                             " + Planet.planetName);
                Console.WriteLine("Mass (1024kg) =                  " + Planet.planetMass);
                Console.WriteLine("Diameter (kg/m3) =               " + Planet.planetDiameter);
                Console.WriteLine("Density (km) =                   " + Planet.planetDensity);
                Console.WriteLine("Gravity (m/s2) =                 " + Planet.planetGravity);
                Console.WriteLine("Rotation Period(Hours) =         " + Planet.planetRotationPeriod);
                Console.WriteLine("Lenght of Day (Hours) =          " + Planet.planetLengthOfDay);
                Console.WriteLine("Distance from Sun (106km) =      " + Planet.planetDistanceToSun);
                Console.WriteLine("Orbital Period (days) =          " + Planet.planetOrbitalPeriod);
                Console.WriteLine("Orbital Velocity (km/s) =        " + Planet.planetOrbitalVelocity);
                Console.WriteLine("Mean Temperature (C) =           " + Planet.planetMeanTemperature);
                Console.WriteLine("Number of Moons =                " + Planet.planetNumberOfMoons);
                Console.WriteLine("Ringsystem? =                    " + Planet.planetRingSystem);
                Console.WriteLine("\n\n");
            }
            Console.ReadLine();

        }
    }
}
