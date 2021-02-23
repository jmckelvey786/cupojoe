using System;

namespace jazzedonjava
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jazzed on Java!");
            bool hascoffee;
            Console.WriteLine("You have had a cup of coffee? 'true' or 'false'");
            hascoffee = bool.Parse(Console.ReadLine());
            if (hascoffee)
            {
                Console.WriteLine("Jazzed!");
            }
            else
            {
                Console.WriteLine("Not jazzed");
            }
        }
    }
}
