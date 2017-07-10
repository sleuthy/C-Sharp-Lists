using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Add() Jupiter and Saturn at the end of the list.
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            // 2. Create another List that contains that last two planet of our solar system.
            List<string> lastTwoPlanets = new List<string>(){"Uranus", "Neptune"};

            // 3. Combine the two lists by using AddRange().
            planetList.AddRange(lastTwoPlanets);

            // 4. Use Insert() to add Earth, and Venus in the correct order.
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            // 5. Use Add() again to add Pluto to the end of the list.
            planetList.Add("Pluto");
            
            foreach (string planet in planetList)
            Console.WriteLine(planet);

            // 6. Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets.
            // Mercury, Venus, Earth, Mars are rocky planets.
            List<string> rockyPlanets = new List<string>(planetList.GetRange(0, 4));
            Console.WriteLine("Rocky Planets: ");
            foreach (string rocky in rockyPlanets){
            Console.WriteLine(rocky);
            }

            // 7. Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it from the end of planetList.
            planetList.RemoveAt(8);

            foreach (string planet in planetList){
            Console.WriteLine(planet);
            }
        }
    }
}








