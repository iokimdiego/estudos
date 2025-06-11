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
    }
}
