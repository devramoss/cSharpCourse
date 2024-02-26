using System;

namespace DadosCliente {
    internal class DadosCliente {
        static void Main(string[] args) {
            Console.WriteLine("Entre com o seu nome completo: ");
            string nome = Console.ReadLine();
            
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int nQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            double valorProduto = double.Parse(Console.ReadLine());
           
            Console.WriteLine("Entre com o seu último nome, idade e altura na mesma linha: ");
            string[] dados = Console.ReadLine().Split(' ');

            Console.WriteLine($"\n\n{nome}");
            Console.WriteLine($"{nQuartos}");
            Console.WriteLine($"R$ {valorProduto}");
            Console.WriteLine($"{dados[0]}, {int.Parse(dados[1])} anos, {double.Parse(dados[2])} de altura");
        }
    }
}