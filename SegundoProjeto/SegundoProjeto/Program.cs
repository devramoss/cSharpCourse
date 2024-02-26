using System;
using System.Globalization;

namespace SegundoProjeto{
    internal class Program{
        static void Main(string[] args){
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1= 2100.0, preco2 = 650.50, medida = 53.234567;
            
            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1} cujo preço é R$ {preco1}");
            Console.WriteLine($"{produto2} cujo preço é R$ {preco2} \n\n");
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero {genero} \n");
            Console.WriteLine($"Medida com oito casas decimais: {medida}");
            Console.WriteLine($"Arredondamento com três casas decimais {medida.ToString("F3")}");
            Console.WriteLine($"Usando o separador decimal invariant culture {medida.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}