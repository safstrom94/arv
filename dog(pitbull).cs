using System;
using System.Collections.Generic;
using System.Text;

namespace arv
{
    class pitbull : Dog
    {
        

        public string WaveTail;
        public pitbull(string name, string walk, string sniff, string run, string eat, string chaseTail, string wavetail)
        {
            {
                this.Name = name;
                this.Walk = walk;
                this.Sniff = sniff;
                this.Run = run;
                this.Eat = eat;
                this.ChaseTail = chaseTail;
                this.WaveTail = wavetail;
            }
        }
        public override void Sleep(bool sleep)
        {
            if (sleep == true)
            {
                Console.WriteLine("ZzzZZzzz");
            }
            else
            {
                Console.WriteLine("not sleeping");
            }
        }
        public override void Age()
        {
            Random age = new Random();
            int Age = age.Next(1, 4);
            Console.WriteLine("is " + Age + " years old");
        }
        public override void MakeSound()
        {
            Console.WriteLine("woffwoff");
        }
        public override void PrintInfo()
        {
            Console.WriteLine(Name + " " + Walk + " " + Sniff + " " + Run + " " + Eat + " " + ChaseTail+" "+ WaveTail);
        }
        public override void search()
        {
            Console.WriteLine(Name + " search for a cat");
        }
    
    }
}