namespace EstruturaCondicionalSwitch;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Selecione a opção desejada: (1) Saldo, (2) Depósito, (3) Saque");
        Console.WriteLine("Digite a opção:");
        var opcao = Console.ReadLine();
        var saldo = 100.00;
        switch (opcao)
        {
            case "1":
                Console.WriteLine($"Seu saldo é de R$ {saldo}");
                break;
            case "2":
                Console.WriteLine("Informe o valor do depósito:");
                var valorDeposito = Console.ReadLine();
                Console.WriteLine($"Você depositou R$ {valorDeposito}");
                saldo += Convert.ToDouble(valorDeposito);
                Console.WriteLine($"Seu novo saldo é de R$ {saldo}");
                break;
            case "3":
                Console.WriteLine("Informe o valor do saque:");
                var valorSaque = Console.ReadLine();
                Console.WriteLine($"Você sacou R$ {valorSaque}");
                saldo -= Convert.ToDouble(valorSaque);
                Console.WriteLine($"Seu novo saldo é de R$ {saldo}");
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}
