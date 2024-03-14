using System; 

namespace Vetores {
    internal class Program{
                static void Main(string[] args) {
                    Aluno[] quartos = new Aluno[10];

                    Console.WriteLine("Deseja reservar quantos quartos?");
                    int n = int.Parse(Console.ReadLine());

                    for(int i=0; i<n; i++){
                        Console.WriteLine("Qual o seu nome?");
                        string nome = Console.ReadLine();

                        Console.WriteLine("Qual o seu e-mail?");
                        string email = Console.ReadLine();

                        Console.WriteLine("Qual o número do quarto que deseja alugar? [0-10]");
                        int numQuarto = int.Parse(Console.ReadLine());
                        
                        Aluno hospede = new Aluno(nome, email, numQuarto);

                        quartos[i] = hospede;
                    }

                    foreach(Aluno hospede in quartos){
                        Console.WriteLine(hospede);
                    }
                }
    }
}