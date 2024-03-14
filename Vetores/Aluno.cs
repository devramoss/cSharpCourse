namespace Vetores{
   public class Aluno {
      public string Nome{get; private set;}
      public string Email{get; private set;}
      public int Quarto{get; private set;}

      public Aluno(string nome, string email, int quarto){
         Nome = nome;
         Email = email; 
         Quarto = quarto;
      }

        public override string ToString() {
            return $"{Nome}, {Email}, quarto {Quarto}";
        }
    }
}