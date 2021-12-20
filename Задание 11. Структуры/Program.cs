using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace Задание_11.Структуры
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nлинейное уравнение ax+b=0");
            Console.WriteLine("\nвведите переменную 'a'");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nвведите переменную 'b'");
            double b = Convert.ToDouble(Console.ReadLine());
            //if (a == 0)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Решений нет");
            //    Console.ForegroundColor = ConsoleColor.White;
            //}
            //else if (a == 0 || b == 0)
            //{
            //    Console.WriteLine("x - любое число");
            //}
            //else
            //{
            //    double result = (-b) / a;
            //    Console.WriteLine($"\nx = {String.Format("{0:0.00}", result)}");
            //}


            Quad quad = new Quad(a, b);
            Console.WriteLine(quad.Root());
            Console.ReadLine();


        }

    }

}
