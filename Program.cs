using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача__1
{
    class Program
    {
        static void Main(String[] args)
        {
            double S, r2, a, P;
            Console.WriteLine("Введите площадь круга: ");
            S = Convert.ToDouble(Console.ReadLine());
            r2 = S/3.14; // находим радиус описанной окружности в 
            a = 2*Math.Sqrt(r2 / 2); // находим сторону квадрата
            S = a * a;
            P = 4 * a;
            Console.WriteLine("Сторона квадрата ={0}", a);
            Console.WriteLine("Площадь квадрата ={0}", S);
            Console.WriteLine("Периметр квадрата ={0}", P);
            Console.ReadLine();


        }
    }
}
