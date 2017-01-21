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
        private int age = 3;
        private int energyLevel;
        private int hungerLevel;
        private int moodLevel;
        private int thirstLevel;

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
        public int Energy
        {
            get { return this.energyLevel; }
            set { this.energyLevel = value; }
        }
        public int Hunger
        {
            get { return this.hungerLevel; }
            set { this.hungerLevel = value; }
        }
        public int Mood
        {
            get { return this.moodLevel; }
            set { this.moodLevel = value; }
        }
        public int Thirst
        {
            get { return this.thirstLevel; }
            set { this.thirstLevel = value; }
        }
        //Constructors
        public VirtualPet(int hungerLevel, int energyLevel, int moodLevel, int thirstLevel)
        {
            this.hungerLevel = hungerLevel;
            this.energyLevel = energyLevel;
            this.moodLevel = moodLevel;
            this.thirstLevel = thirstLevel;

        }
        public VirtualPet(int hungerLevel, int thirstLevel)
        {
            this.energyLevel = 100;
            this.moodLevel = 10;
            this.thirstLevel = 10;
            this.hungerLevel = 10;

        }


        //Method

        public void OrithePandaIssue()
        {
            int hungerLevel = Hunger;
            if (Hunger <= 60)
            {

                Console.WriteLine("Now let's help your pet.. What do you want to do now? Would you like to ");
            }



        }



        public void DisplayOrithePanda()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Ori the Panda's hunger level: " + hungerLevel);
            Console.WriteLine("Ori the Panda's energy level: " + energyLevel);
            Console.WriteLine("Ori the Panda's mood level: " + moodLevel);
            Console.WriteLine("Ori the Panda's thirst level: " + thirstLevel);
            Console.WriteLine("________________________________________________________");

        }

    }
}
