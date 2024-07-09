using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите положительные числа A, B, C");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            int s = 0;
            while (a - c >= 0)
            {
                a -= c;
                while (b - c >= 0) 
                {
                    b -= c;
                    ++s;
                }
            }
            Console.WriteLine("Колличество квадратов стороной С: {0}", s);
        }
    }
}
