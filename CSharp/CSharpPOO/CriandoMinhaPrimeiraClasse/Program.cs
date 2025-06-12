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

        Console.WriteLine(conta.ExibirExtrato()); // Exibe o extrato da conta no console
        conta.Depositar(1000); // Deposita R$ 1000,00 chamando o método Depositar
        Console.WriteLine(conta.ExibirExtrato()); // Exibe o extrato da conta no console
        conta.Sacar(500); // Realiza um saque de R$ 500,00 chamando o método Sacar
        Console.WriteLine(conta.ExibirExtrato()); // Exibe o extrato da conta no console
        conta.Sacar(600); // Tenta sacar R$ 600,00, mas não tem saldo suficiente
        Console.WriteLine(conta.ExibirExtrato()); // Exibe o extrato da conta no console
    }
}
