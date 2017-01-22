using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetProj
{
    class VirtualPet
    {
        //Fields
        private string name = "Ori";
        private string color = "Black/White";
        private int age = 300;
        private int strengthLevel;
        private int powerLevel;
        private int dexterityLevel;
        private int magicLevel;

        //Properties 
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
        public int Age

        {
            get { return this.age; }
            set { this.age = value; }
        }
        public int Strength
        {
            get { return this.strengthLevel; }
            set { this.strengthLevel = value; }
        }
        public int Power
        {
            get { return this.powerLevel; }
            set { this.powerLevel = value; }
        }
        public int Dexterity
        {
            get { return this.dexterityLevel; }
            set { this.dexterityLevel = value; }
        }
        public int Magic
        {
            get { return this.magicLevel; }
            set { this.magicLevel = value; }
        }
        //Constructors
        public VirtualPet(int powerLevel, int strengthLevel, int dexterityLevel, int magicLevel)
        {
            this.powerLevel = powerLevel;
            this.strengthLevel = strengthLevel;
            this.dexterityLevel = dexterityLevel;
            this.magicLevel = magicLevel;

        }
        public VirtualPet(int strength, int dexterityLevel)
        {
            this.strengthLevel = 10;
            this.dexterityLevel = 10;
            this.magicLevel = 10;
            this.powerLevel = 10;

        }


        //Method

        public void OrithePandaIssue()
        {
            int strengthLevel = Strength;
            if (Strength <= 60)
            {

                Console.WriteLine("Your family has the ability to improve my powers by typing in a letter in the console.  You're what we like to call a 'Console Master'. It's a special ability only given to those who are very cool.  Be sure to make me stronger and increase my magic level.  Otherwise the Red Dragon will eat us alive and use what remains of our bones as a toothpicks! ");
            }



        }



        public void DisplayOrithePanda()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("________________________________________________________");
            Console.WriteLine("Ori the Panda's power level: " + powerLevel);
            Console.WriteLine("Ori the Panda's strength level: " + strengthLevel);
            Console.WriteLine("Ori the Panda's dexterity level: " + dexterityLevel);
            Console.WriteLine("Ori the Panda's magic level: " + magicLevel);
            Console.WriteLine("________________________________________________________");

        }
        public void OritheMoody()
        {
            while (true)
            {
                Console.WriteLine("1. ");
                Console.WriteLine("2. ");
                Console.WriteLine("3. ");
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
                    Console.WriteLine("Ori is happy!");
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
