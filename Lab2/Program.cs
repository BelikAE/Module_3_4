using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число");
            int countP = 0;
            int countM = 0;
            int n;
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                    countP += 1;
                else if (n < 0)
                    countM += 1;

            } while (n != 0);

            if (countP > countM)
            {
                Console.WriteLine("Количество положительных - {0}, больше количества отрицательных - {1}", countP, countM);
            }
            else if (countP < countM)
            {
                Console.WriteLine("Количество положительных - {0},  меньше количества отрицательных - {1}", countP, countM);
            }   
            else
            {
                Console.WriteLine("Количество положительных - {0},  равно количества отрицательных - {1}", countP, countM);
            }
                
            Console.ReadKey();
        }
    }
    
}
