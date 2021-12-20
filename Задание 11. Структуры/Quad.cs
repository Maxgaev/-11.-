using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание_11.Структуры
{
    struct Quad
    {
        double a, b;


        public Quad(double a, double b)
        {
            this.a = a;
            this.b = b;

        }
        public string Root()
        {
            double result = (-b) / a;
            return $"\nx = = {String.Format("{0:0.00}", result)}";
        }

    }

}