using Contas;

namespace CriandoMinhaPrimeiraClasse;

class Program
{
    static void Main(string[] args)
    {
        var conta = new Conta();
        conta.Numero = "12345-6";
        conta.DataAbertura = DateTime.Today;
        conta.Saldo = 0;

        conta.ExibirExtrato();
        conta.Depositar(1000); // Deposita R$ 1000,00 chamando o método Depositar
        conta.ExibirExtrato();
        conta.Sacar(500); // Realiza um saque de R$ 500,00 chamando o método Sacar
        conta.ExibirExtrato();
        conta.Sacar(600); // Tenta sacar R$ 600,00, mas não tem saldo suficiente
        conta.ExibirExtrato();
    }
}
