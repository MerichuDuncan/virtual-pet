using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you like Panda? \nType yes or no");
            string panda = Console.ReadLine();
            if (panda.ToLower() == "yes")
            {
                Console.WriteLine("You belong in an awesome group!");

                Console.WriteLine("Please enter your first name?");
                string firstName = Console.ReadLine();
                if (firstName == firstName)
                {
                    Console.WriteLine("\n" + firstName + ", meet your new pet: ");
                    VirtualPet pet1 = new VirtualPet(100, 50);
                    pet1.DisplayOrithePanda();
                    pet1.OrithePandaIssue();
                    OritheMoody();


                }
            }
        }
        static void OritheMoody()
        {
            while (true)
            {
                Console.WriteLine("1. Feed him");
                Console.WriteLine("2. Give him water");
                Console.WriteLine("3. Pet him");
                int answer = int.Parse(Console.ReadLine());
                if (answer == 1)
                {
                    Console.WriteLine("Ori the Panda's food level is 100%");

                }

                else if (answer == 2)
                {
                    Console.WriteLine("Ori the Panda's water level is 100%");

                }
                else if (answer == 3)
                {
                    Console.WriteLine(" Ori is happy!");
                    break;

                }
                else
                {
                    Console.WriteLine("Forget it!");
                }

                //string[] mood = new string[4];
                //mood[0] = "1.Feed him";
                //mood[1] = "2.Give him water";
                //mood[2] = "3.Pet him";
                //mood[3] = "4. Give him some air";

            }
        }
    }
}
