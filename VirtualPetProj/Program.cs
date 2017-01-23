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
            
            Console.WriteLine("                W    E    L    C    O   M   E\n");

            OrithePanda();
            Console.WriteLine("\nPlease enter your first name to start?");
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
                    OrithePanda();
                }



            }













        }
        static void OrithePanda()
                
            {
                Console.WriteLine("       ___oo#:#o__");
                Console.WriteLine("     o##########o###-");
                Console.WriteLine("    ####o#~:~#~#####:~o______________");
                Console.WriteLine("    #####o~ -- ~  ~~~~ ~            ~~--_   _o---~- -o");
                Console.WriteLine("   ~-##~_~-__                           ~-~::######oo:o");
                Console.WriteLine("   ~-##~_~-__                           ~-~::######oo:o");
                Console.WriteLine("     ~~##-~~ ~   _oooooo___        o_____    ~ ~~~#~##~o_");
                Console.WriteLine("     ~~##-~~ ~   _oooooo___        o_____    ~ ~~~#~##~o_");
                Console.WriteLine("   _~~~~     _o##############__  _########o_      #~~~####");
                Console.WriteLine(" o~         o#####~~~~~~#####~~ #############o    ~-###_~o");
                Console.WriteLine(" #o       _####_~  _ooo#o###:   ########~~:###:_   ~####~");
                Console.WriteLine("o~        #o####_o_######~#o#    #######-  ~-##_##~#--~");
                Console.WriteLine("#         ###########~~~~:::~     ~######    #######_");
                Console.WriteLine("#          #######:~~~ ~########o_  ######o_o########");
                Console.WriteLine("#          -~~~~~~~     ~########~ _#################");
                Console.WriteLine(" ~_            _         ~~#~~~ ~ -#~################");
                Console.WriteLine("  ~_        _  ~-__       o~        ~~###########~#-");
                Console.WriteLine("   ~o_  -_  #      ~~~~---#              ~~~-~~:_~~");
                Console.WriteLine("  _oo_~-_:~~~o             ~o_          ____--~ ~~#__    ____");
                Console.WriteLine("#####o#_-~-~#o #_o---          :#::~#--##~--ooo_o_o###~:    ~~_");
                Console.WriteLine("######:o-    ~#_ ~##o_      __-~~####oo_~~~~-_:~ ##o_   ~~o_o-~~");
                Console.WriteLine("######~~~      ~o:~~###o--~~      ~~~####oo_  ~~  ~###  ##o~~-_");
            }
        }
    }

