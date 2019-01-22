using System;

namespace L1_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 Numbers: ");
            int x, y, z;
            Console.WriteLine("Input first number");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Input second number");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Input third number");
            z = int.Parse(Console.ReadLine());

            if ( x >= y && x >= z)
            {
                Console.WriteLine("The greatest number is = {0}", +x);
                Console.ReadLine();
            }
            else if (y >= x && y >= z)
            {
                Console.WriteLine("The greatest number is = {0}", +y);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The greatest number is = {0}", +z);
                Console.ReadLine();
            }
        }
    }
}
