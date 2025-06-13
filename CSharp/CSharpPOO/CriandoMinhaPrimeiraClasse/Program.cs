using Contas;

namespace CriandoMinhaPrimeiraClasse;

class Program
{
    static void Main(string[] args)
    {
        var conta = new Conta();
        conta.Numero = "12345-6";
        conta.DataAbertura = DateTime.Today;
        conta.Saldo = 100;
        conta.RealizarEmprestimo(200, 10); // Realiza um empréstimo de R$ 200,00 chamando o método RealizarEmprestimo
        
        Console.WriteLine(Conta.TaxaRendimento); // Exibe a taxa de rendimento da conta no console
        Console.WriteLine(Conta.CalcularRendimento(100, 12)); // Exibe o rendimento de R$ 100,00 em 12 meses chamando o método CalcularRendimento

        Console.WriteLine(conta.ExibirExtrato()); // Exibe o extrato da conta no console
        conta.Depositar(1000); // Deposita R$ 1000,00 chamando o método Depositar
        Console.WriteLine(conta.ExibirExtrato()); // Exibe o extrato da conta no console
        conta.Sacar(500); // Realiza um saque de R$ 500,00 chamando o método Sacar
        Console.WriteLine(conta.ExibirExtrato()); // Exibe o extrato da conta no console
        conta.Sacar(600); // Tenta sacar R$ 600,00, mas não tem saldo suficiente
        Console.WriteLine(conta.ExibirExtrato()); // Exibe o extrato da conta no console
    }
}
