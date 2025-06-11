// namespace CriandoMinhaPrimeiraClasse
namespace Contas
{
    public class Conta
    {
        // Atributos da classe Conta
        // Atributos são as características que definem a classe
        public string Numero;
        public DateTime DataAbertura;
        public decimal Saldo;

        // Métodos da classe Conta
        // Métodos são as ações que a classe pode realizar
        public void ExibirExtrato()
        {
            Console.WriteLine("===================================");
            Console.WriteLine($"Número da Conta:..........{Numero}");
            Console.WriteLine($"Data de Abertura:.........{DataAbertura.ToShortDateString()}");
            Console.WriteLine($"Saldo Atual:..............{Saldo:C}"); // Formata o saldo como moeda
            Console.WriteLine("===================================");
        }
    }
}