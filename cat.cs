using System;
using System.Collections.Generic;
using System.Text;

namespace arv
{
    public class Cat : Djur
    {
        public Cat(string name, string walk, string sniff, string run, string eat,string sneakAttack)
        {
            {
                this.Name = name;
                this.Walk = walk;
                this.Sniff = sniff;
                this.Run = run;
                this.Eat = eat;
                this.SneakAttack = sneakAttack;
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
            int Age = age.Next(1, 20);
            Console.WriteLine("is " + Age + " years old");
        }
        public override void MakeSound()
        {
            Console.WriteLine("meow");
        }
        public override void PrintInfo()
        {
            Console.WriteLine(Name +" "+ Walk+" "+Sniff+" "+Run+" "+Eat+" "+ SneakAttack);
        }
        public void climbtree()
        {
            Console.WriteLine(Name+ "climbs up a tree");
        }
    string SneakAttack;
    }
}