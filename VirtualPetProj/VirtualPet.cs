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
            this.strengthLevel = 50;
            this.dexterityLevel = 50;
            this.magicLevel = 50;
            this.powerLevel = 50;

        }


        //Method

        public void OrithePandaIssue()
        {
            int strengthLevel = Strength;
            if (Strength <= 60)
            {
                Console.WriteLine("Your family has the ability to improve my powers by typing in a letter in the console.\nYou're what we like to call a 'Console Master'. It's a special ability only given to those who are very cool.\nBe sure to make me stronger and increase my magic level.  Otherwise the Red Dragon will eat us alive and use what remains of our bones as toothpicks! \nPress A to get to know me more or B to skip the intro");
                string userAnswer = Console.ReadLine();
                if (userAnswer.ToLower() == "a")
                {
                    Console.WriteLine("Name: " + name);
                    Console.WriteLine("Age: " + age);
                    Console.WriteLine("Color: " + color);
                    Console.WriteLine("________________________________________________________");

                    Console.WriteLine("\nOri the Panda's power level: " + powerLevel);
                    Console.WriteLine("Ori the Panda's strength level: " + strengthLevel);
                    Console.WriteLine("Ori the Panda's dexterity level: " + dexterityLevel);
                    Console.WriteLine("Ori the Panda's magic level: " + magicLevel);
                    Console.WriteLine("________________________________________________________\n I need you help!");

                }
                else
                {
                    Console.WriteLine("You hurt me so bad, help me by entering a number to update my level status inorder for me to fight the dragon");
                    Console.WriteLine("Ori the Panda's power level: " + powerLevel);
                    Console.WriteLine("Ori the Panda's strength level: " + strengthLevel);
                    Console.WriteLine("Ori the Panda's dexterity level: " + dexterityLevel);
                    Console.WriteLine("Ori the Panda's magic level: " + magicLevel);
                    Console.WriteLine("________________________________________________________");

                }
            }
        }
            public void OritheMoody()
        {
            while (true)
    
            {

                Console.WriteLine("1. Add power ");
                Console.WriteLine("2. Add strength ");
                Console.WriteLine("3. Add dexterity ");
                Console.WriteLine("4. Add magic");
                Console.WriteLine("5. Finished ");

                int answer = int.Parse(Console.ReadLine());
                
                if (answer == 1)

                {
                    Console.WriteLine("Ori the Panda's power level is: " + (powerLevel + powerLevel));
                    Console.WriteLine("Ori the Panda's strength level: " + strengthLevel);
                    Console.WriteLine("Ori the Panda's dexterity level: " + dexterityLevel);
                    Console.WriteLine("Ori the Panda's magic level: " + magicLevel);
                    Console.WriteLine("I'm still not ready! I need more!\n");

                }
          

                else if (answer == 2 || answer==1)
                {

                    Console.WriteLine("Ori the Panda's strength level is: " + (strengthLevel + strengthLevel));
                    Console.WriteLine("Ori the Panda's power level: " + (powerLevel+powerLevel));
                    Console.WriteLine("Ori the Panda's dexterity level: " + dexterityLevel);
                    Console.WriteLine("Ori the Panda's magic level: " + magicLevel);
                    Console.WriteLine("I'm still not ready! I need more!\n");


                }

                else if (answer == 3|| answer==2 ||answer==1)


                {
                    Console.WriteLine("Ori the Panda's dexterity level is: " + (dexterityLevel + dexterityLevel));
                    Console.WriteLine("Ori the Panda's power level: " + (powerLevel+powerLevel));
                    Console.WriteLine("Ori the Panda's strength level: " + (strengthLevel+strengthLevel));
                    Console.WriteLine("Ori the Panda's magic level: " + magicLevel);
                    Console.WriteLine("I'm still not ready! I need more!\n");


                }

                else if (answer == 4 || answer==3||answer==2||answer==1)
                {

                    Console.WriteLine("Ori the Panda's magic level is: " + (magicLevel+ magicLevel));
                    Console.WriteLine("Ori the Panda's power level: " + (powerLevel+powerLevel));
                    Console.WriteLine("Ori the Panda's strength level: " + (strengthLevel+strengthLevel));
                    Console.WriteLine("Ori the Panda's dexterity level: " + (dexterityLevel+dexterityLevel));
                    Console.WriteLine("I'm full! Whenever your ready just enter 5\n");
                    
                }
                else
                {
                    Console.WriteLine(" \nNow I'm ready to slay the dragon!");
                    break;
                }








            }
        }
      
    }
}


