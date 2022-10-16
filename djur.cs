using System;

namespace arv
{
    public abstract class Djur
    {
        public virtual void Age()
        {
            Random age = new Random();
            int Age = age.Next(1, 20);
            Console.WriteLine("is " + Age + " years old");
        }
        public string Name;
        public string Walk;
        public string Sniff;
        public string Run;
        public string Eat;
        public virtual void Sleep(bool sleep)
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

        public virtual void MakeSound()
        {
            Console.WriteLine("sound");
        }
        public abstract void PrintInfo();

    }
}
//[ ]  Klassen ska ha minst fem egenskaper som alla djur delar med varandra
//[ ]  Klassen ska också minst tre metoder som alla djuren delar med varandra
//[ ]  Alla djur måste ha en metod som heter `makeSound()` och som ska skriva ut djurets läte i consolen