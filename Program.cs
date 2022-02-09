using System;

namespace hungry_ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninja shinobi = new Ninja();
            Buffet dojobrunch = new Buffet();

            while(!shinobi.IsFull)
            {
                shinobi.Eat(dojobrunch.Serve());
            }
            Console.WriteLine($"Ninja is stuffed");
        }
    }
}
