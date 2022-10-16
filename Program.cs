using System;

namespace arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog Dog1 = new Dog("Thunder. ", "starts to walk. ", "sniffs food. ","starts to run. ","eat.", "chase tail.");
            bulldog Dog2 = new bulldog("super. ", "starts to walk. ", "sniffs food. ", "starts to run. ", "eat.", "chase tail.","jumps.");
            pitbull Dog3 = new pitbull("frank. ", "starts to walk. ", "sniffs food. ", "starts to run. ", "eat.", "chase tail.","wavetail.");
            Cat Cat1 = new Cat("Max. ", "starts to walk. ", "sniffing a mouse. ","starts to run. ", "eat.","try to sneak attack a bird.");
            Bird Bird1 = new Bird("flax. ", "starts to walk. ", "cant smell. ","cant run. ", "eat.", "attack humen with bird poop");

            
            Cat1.PrintInfo();
            Cat1.Age();
            Cat1.MakeSound();
            Cat1.Sleep(false);
            Cat1.climbtree();
            Console.WriteLine();
            Dog1.PrintInfo();
            Dog1.Age();
            Dog1.MakeSound();
            Dog1.Sleep(true);
            Dog1.search();
            Console.WriteLine();
            Bird1.PrintInfo();
            Bird1.Age();
            Bird1.MakeSound();
            Bird1.Sleep(false);
            Bird1.fly();
            Console.WriteLine();
            Dog2.PrintInfo();
            Dog2.Age();
            Dog2.MakeSound();
            Dog2.Sleep(true);
            Dog2.search();
            Console.WriteLine();
            Dog3.PrintInfo();
            Dog3.Age();
            Dog3.MakeSound();
            Dog3.Sleep(false);
            Dog3.search();
            Console.WriteLine();



            Console.ReadKey();
        }
    }
}
