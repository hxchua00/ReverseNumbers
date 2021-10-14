using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number here: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int Reverse = 0;
            while (num > 0)
            {
                int remainder = num % 10;
               //Console.WriteLine($"Remainder: {remainder}");
                Reverse = (Reverse * 10) + remainder;
               //Console.WriteLine($"Reverse: {Reverse}");
                num = num / 10;
               //Console.WriteLine($"Num: {num}");
            }

            Console.WriteLine($"Reversed Number: {Reverse}");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
