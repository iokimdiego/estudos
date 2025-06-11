// namespace CriandoMinhaPrimeiraClasse
namespace Contas
{
    public class Conta
    {
        // Atributos da classe Conta
        // Atributos são as características que definem a classe
        public string Numero = "";
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

        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor do depósito deve ser maior que zero.");
                return;
            }
            Saldo += valor;
            Console.WriteLine($"Depósito de {valor:C} realizado com sucesso.");
        }
        public void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor do saque deve ser maior que zero.");
                return;
            }
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque.");
                return;
            }
            Saldo -= valor;
            Console.WriteLine($"Saque de {valor:C} realizado com sucesso.");
        }
    }
}