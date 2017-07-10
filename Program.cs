using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            Console.WriteLine("First List");
            Console.WriteLine("-----------");
            foreach (string planet in planetList) {
                Console.WriteLine(planet);
            }
            List<string> planetList2 = new List<string>(){"Uranus", "Neptune"};
            planetList.AddRange(planetList2);
            Console.WriteLine("-----------");
            Console.WriteLine("AddRange List");
            Console.WriteLine("-----------");
            foreach (string planet in planetList) {
                Console.WriteLine(planet);
            }
            planetList.Insert(1, "Earth");
            planetList.Insert(1, "Venus");
            Console.WriteLine("-----------");
            Console.WriteLine("Insert Earth and Venus List");
            Console.WriteLine("-----------");
             foreach (string planet in planetList) {
                Console.WriteLine(planet);
            }
            planetList.Add("Pluto");
            Console.WriteLine("-----------");
            Console.WriteLine("Add Pluto List");
            Console.WriteLine("-----------");
             foreach (string planet in planetList) {
                Console.WriteLine(planet);
            }
            string[] rockyPlanets = planetList.GetRange(0,4).ToArray();
            Console.WriteLine("-----------");
            Console.WriteLine("GetRange - Rocky Planet List");
            Console.WriteLine("-----------");
             foreach (string planet in rockyPlanets) {
                Console.WriteLine(planet);
            }
            planetList.Remove("Pluto");
            Console.WriteLine("-----------");
            Console.WriteLine("Remove Pluto List");
            Console.WriteLine("-----------");
             foreach (string planet in planetList) {
                Console.WriteLine(planet);
            }

        }
    }
}
