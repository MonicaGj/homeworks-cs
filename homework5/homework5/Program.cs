using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    class Program
    {
        class Wizard
        {
            public string Name;
            public int PowerLevel;
            public int Age;
            public DateTime Date;
            public bool GraduationStatus;

            public Wizard(string name, int powerLevel, int age, DateTime date, bool graduationStatus)
            {
                this.Name = name;
                this.PowerLevel = powerLevel;
                this.Age = age;
                this.Date = date;
                this.GraduationStatus = graduationStatus;

            }

            public new Creature creature; 

            public void OwnCreature(Creature creature){
                if(this.PowerLevel > creature.PowerLevel)
                {
                    creature.Timed = true;
                    Console.WriteLine($"{this.Name} win the duel and {creature.Name} is timed.");
                }
            }
        }



        class Creature
        {
            public string Name;
            public int Age;
            public int PowerLevel;
            public bool Timed;

            public Creature(string name, int age, int powerLevel, bool timed)
            {
                this.Name = name;
                this.Age = age;
                this.PowerLevel = powerLevel;
                this.Timed = false;
            }
           
        }

        static void Main(string[] args)
        {
            //Wizard[] wizards = new Wizard[]
            //{
            //   new Wizard("Jhon", 28, 15, DateTime.Today, true),
            //   new Wizard("Maraja", 20, 12, DateTime.Today, true),
            //};


            //for (int i = 0; i < wizards.Length; i++)
            //{
            //    Console.WriteLine($"{wizards[i].Name},{wizards[i].PowerLevel},{wizards[i].Age}," +
            //        $"{wizards[i].Date},{wizards[i].GraduationStatus}");
            //}

            //Creature[] creatures = new Creature[]
            //{
            //    new Creature("Fire", 4, 23, false),
            //    new Creature("Water", 2, 20, false),
            //};

            //for (int i = 0; i < wizards.Length; i++)
            //{
            //    for (int j = 0; j < creatures.Length; j++)
            //    {
            //        if(wizards[i].PowerLevel > creatures[j].PowerLevel)
            //        {
            //            creatures[j].Timed = true;
            //            Console.WriteLine($"{wizards[i].Name} win the duel and {creatures[j].Name} is timed.");
            //        }
            //    }
            //}



            Wizard Jhon = new Wizard("Jhon", 28, 15, DateTime.Today, true);
            Wizard Maraja = new Wizard("Maraja", 20, 12, DateTime.Today, true);
            Creature Fire = new Creature("Fire", 4, 23, false);
            Creature Water = new Creature("Water", 2, 20, false);

            Jhon.OwnCreature(Fire);
            Console.ReadLine();
        }
    }
}
