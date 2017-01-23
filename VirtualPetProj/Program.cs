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
            Console.WriteLine("Please enter your first name to start?");
            string firstName = Console.ReadLine();
            if (firstName == firstName)

                Console.WriteLine("\nWelcome! " + firstName + ", 275 years ago, I helped your Great, Great, Great, Great, Great Grandfather slay the Red Dragon.\nNow he's been reserected and I want to help you defeat him. While I'm very old,\nI like to snuggle and play when I'm not killing ancient monsters.\nJust think of me as your pet!");

            Console.WriteLine("\nDo you like Pandas? \nType yes or no");

            string panda = Console.ReadLine();
            if (panda.ToLower() == "yes")
            {

                Console.WriteLine("Great! You're just like your ancient relatives who recognized the wisdom, sharp intellect, and cuddly nature of pandas");
            }
            else
            {
                Console.WriteLine("That's too bad, I was thinking about giving you a million dollars after we slay the red dragon. Instead I guess we'll just go our separate ways once we chopped off his head and hang it like an ornament above the fire place!");
            }
            {

                {
                    Console.WriteLine("\n" + firstName + ", I need you help!: ");
                    VirtualPet pet1 = new VirtualPet(50, 50, 50, 50);
                    pet1.OrithePandaIssue();
                    pet1.OritheMoody();
                }



            }

        }
    }
}
