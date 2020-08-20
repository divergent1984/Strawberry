using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strawberry
{
    class Program
    {
        static void Main(string[] args)
        {
            //создаём  рандомно три числа.
            Random rnd = new Random();
            int X = rnd.Next(1, 1000);
            int Y = rnd.Next(1, 1000);
            int Z = rnd.Next(1, 1000);
            // находим суму двух чисел.
            int Sum = X + Y;
            //находим разничу между сумой двох чисел и третим числом.
            int Sum1 = Sum - Z;
            if (Sum > Sum1 && Sum1 > 0)
            {
                 Console.WriteLine($" осталось {Sum1} земляники.");
            }
            else 
            {
                Console.WriteLine("невозможно съесть больше чем собрано!");
            }           
                Console.ReadKey();
        }
    }
}
