using System;

namespace arv
{
    class bulldog: Dog
    {
        public string Jump;
        public bulldog(string name, string walk, string sniff, string run, string eat, string chaseTail, string jump)
        {
            {
                this.Name = name;
                this.Walk = walk;
                this.Sniff = sniff;
                this.Run = run;
                this.Eat = eat;
                this.ChaseTail = chaseTail;
                this.Jump = jump;
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
            Console.WriteLine(Name + " " + Walk + " " + Sniff + " " + Run + " " + Eat + " " + ChaseTail+ " "+ Jump);
        }
        public override void search()
        {
            Console.WriteLine(Name + " search for ball");
        }
    
    }
}
