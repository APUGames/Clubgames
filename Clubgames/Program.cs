using Clubgames.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Clubgames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your club needs members!");
            Console.WriteLine("Decide who gets in and who doesn't, it won't be easy! you can only have 4 other members!");

            string[] candidates = new string[] { "Leonardo", "Raphael", "Michaelangelo", "Donatello", "Shrek", "A Gorilla", "Mr President"};
            Person[] clubMembers = new Person[4];

            Person[] p1 = new Person[4];


            for(int p1Index = 0; p1Index < p1.Length; p1Index++)
            {
                p1[p1Index] = new Person(candidates[p1Index]);
            }

            int guestIndex = 0;

            foreach (Person candidate in p1)
            {
                candidate.SetAge();
                Console.WriteLine($"Do you want to add {candidate.GetName()} Age {candidate.GetAge()} to your club? (yes/no)");
                string input = Console.ReadLine().ToLower();
                if (input == "yes")
                {
                    clubMembers[guestIndex] = candidate;
                    guestIndex++;
                }
                else
                {
                    Console.WriteLine($"{candidate.GetName()} has been denied entry.");
                }
                if(guestIndex >= 4)
                {
                    Console.WriteLine("Your club is now full!");
                    break;
                }
            }
            Console.WriteLine("The following guests are in your club");
            foreach (var member in clubMembers)
            {
                if(member != null) {
                    Console.WriteLine(member.GetName());
                }
                
            }
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
