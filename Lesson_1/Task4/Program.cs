using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            double more = 1.02;
            float less = 2.363f;
            more /= 2;
            less /= 2;
            double more2 = 1.0/2;
            float less2 = 1f/2;
            float less3 = (float)1 / 2;
            Console.WriteLine($"More/2 = {more}");
            Console.WriteLine($"Less/2 = {less}");
            Console.WriteLine($"More2/2 = {more2}");
            Console.WriteLine($"Less2/2 = {less2}"); ;
            Console.WriteLine($"Less3/2 = {less3}");
        }
    }
}
