using System.ComponentModel.Design;

namespace Programming._2
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print numbers 1-100");
            for (int x = 1; x <= 100; x++)
            { 
                if (x % 3 == 0 && x % 5 == 0)
                {
                    Console.WriteLine("Hello, Goodbye");
                }
                else if (x % 3 == 0)
                {
                    Console.WriteLine("Hello");
                }
                else if (x % 5 == 0)
                {
                    Console.WriteLine("Goodbye");
                }
                else
                {
                    Console.WriteLine(x);
                }
                
            }
        }
    }
}
