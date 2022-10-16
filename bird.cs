using System;
using System.Collections.Generic;
using System.Text;

namespace arv
{
    public class Bird : Djur
    {
        public Bird(string name, string walk, string sniff, string run, string eat,string attack)
        {
            {
                this.Name = name;
                this.Walk = walk;
                this.Sniff = sniff;
                this.Run = run;
                this.Eat = eat;
                this.Attack = attack;
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
            Console.WriteLine("is "+ Age+ " years old");
        }
        public override void MakeSound()
        {
            Console.WriteLine("whistle");
        }
        public override void PrintInfo()
        {
            Console.WriteLine(Name + " " + Walk + " " + Sniff + " " + Run + " " + Eat+ " "+Attack);
        }
        public void fly()
        {
            Console.WriteLine(Name+ "starts to fly");
        }
    string Attack;
    }
}