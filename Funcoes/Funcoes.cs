using System;

namespace Funcoes {
    internal class Funcoes {
        static void Main(string[] args) {
            Console.WriteLine("Digite o primeiro número inteiro: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número inteiro: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número inteiro: ");
            int n3 = int.Parse(Console.ReadLine());

            Console.WriteLine($"O maior dos três números é: {MaiorNumero(n1, n2, n3)}");
        }

        static int MaiorNumero(int a, int b, int c) {
            int m;

            if(a > b && a > c)
                m = a;
            else if(b > c)
                m = b;
            else 
                m=c;
            
            return m;
        }
    }
}