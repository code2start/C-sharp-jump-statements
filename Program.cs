using System;

namespace jumpstatements
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                    //break
                    //return;
                    //continue;
                    goto x;
                Console.WriteLine($"Item number {i}");
            }
            Console.WriteLine("In the main method");
            x://label
            Console.WriteLine("I'm gotto keyword");
        }
    }
}
