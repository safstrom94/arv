﻿using System;

namespace arv
{
    public class Dog : Djur
    {
        public Dog() { }
        public Dog(string name, string walk, string sniff, string run, string eat,string chaseTail)
        {
            {
                this.Name = name;
                this.Walk = walk;
                this.Sniff = sniff;
                this.Run = run;
                this.Eat = eat;
                this.ChaseTail = chaseTail;
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
            int Age = age.Next(5, 20);
            Console.WriteLine("is " + Age + " years old");
        }
        public override void MakeSound()
        {
            Console.WriteLine("woffwoff");
        }
        public override void PrintInfo()
        {
            Console.WriteLine(Name + " " + Walk + " " + Sniff + " " + Run + " " + Eat+" "+ ChaseTail);
        }
        public virtual void search()
        {
            Console.WriteLine(Name + " starts to search");
        }
    public string ChaseTail;
    }
}