﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    class UsandoDelegates
    {
        delegate double Soma(double a, double b);
        delegate void ImprimirSoma(double a, double b);

        static double MinhaSoma(double a, double b)
        {
            return a + b;
        }

        static void MeuImprimirSoma(double a, double b)
        {
            Console.WriteLine(a + b);
        }
        public static void Executar()
        {
            Soma op1 = MinhaSoma;
            Console.WriteLine(op1(2, 5));

            ImprimirSoma op2 = MeuImprimirSoma;
            op2(5, 2);

            Func<double, double, double> op3 = MinhaSoma;
            Console.WriteLine(op3(4.5, 1));

            Action<double, double> op4 = MeuImprimirSoma;
            op4(2.5,  18.3);
        }
    }
}
