namespace TrabalhandoComClasses;

class Program
{
    class Aluno
    {
        public string Nome;
        public int Idade;
    }
    static void Main(string[] args)
        {
            var aluno1 = new Aluno();
            aluno1.Nome = "João";
            aluno1.Idade = 20;
            Console.WriteLine($"O aluno {aluno1.Nome} tem {aluno1.Idade} anos de idade.");
        }
}
