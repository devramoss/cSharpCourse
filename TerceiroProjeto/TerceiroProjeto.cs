using System;

namespace TerceiroProjeto {
    internal class TerceiroProjeto {
        static void Main(string[] args) {
            //Definindo a equação
            double a=1.0, b=-3.0, c=-4.0;
            // Calculando o delta
            double delta = Math.Pow(b, 2.0)-4.0*a*c;
            // Calculando as raízes
            double x1 = (-b + Math.Sqrt(delta))/2*a;
            double x2 = (-b -Math.Sqrt(delta))/2*a;

            Console.WriteLine($"As raízes de {a}x²{b}x{c} são:");
            Console.WriteLine($"x' = {x1}\nx'' = {x2}");
        }
    }
}