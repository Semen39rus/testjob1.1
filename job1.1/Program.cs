using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace job11
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Round(Math.Log10(5 - 1)));
            Console.ReadKey();
        }
        public static double Ln(double x)
        {
            const double eps = 1e-15;  // погрешность вычислений
            double s = 0;  // начальная сумма
            double r = x;   // первый член ряда
            int n = 1;         // показатель степени
            while (Math.Abs(r) > eps) // условие выполнения цикла
            {
                s = s + r;      // добавление члена ряда
                n = n + 2;  // наращивание  n:  1,3,5,7,...
                r = -r * Math.Log10(x - 1); // новый член ряда
            }
            return s;       // возврат результата
        }
    }
    
}
