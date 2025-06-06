namespace EstruturaCondicionalSwitch;

class Program
{
    static void Main(string[] args)
    {
        var saldo = 100.00;
        var opcao = "";
        do
        {
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Selecione a opção desejada: (1) Saldo, (2) Depósito, (3) Saque, (0) Sair");
            Console.Write("Digite a opção: ");
            opcao = Console.ReadLine();
            Console.WriteLine("");
            // var saldo = 100.00;
            switch (opcao)
            {
                case "1":
                    Console.WriteLine($"Seu saldo é de R$ {saldo}");
                    break;
                case "2":
                    Console.Write("Informe o valor do depósito:");
                    var valorDeposito = Console.ReadLine();
                    Console.WriteLine($"Você depositou R$ {valorDeposito}");
                    saldo += Convert.ToDouble(valorDeposito);
                    Console.WriteLine($"Seu novo saldo é de R$ {saldo}");
                    break;
                case "3":
                    Console.Write("Informe o valor do saque:");
                    var valorASacar = Console.ReadLine();
                    var valorSaque = Convert.ToDouble(valorASacar);
                    if ((saldo - valorSaque) >= 0)
                    {
                        Console.WriteLine($"Você sacou R$ {valorSaque}");
                        saldo -= Convert.ToDouble(valorSaque);
                        Console.WriteLine($"Seu novo saldo é de R$ {saldo}");
                    }
                    else
                    {
                        Console.WriteLine("Saldo indisponível!");
                    }
                    break;
                case "0":
                    Console.WriteLine("Atendimento encerrado! Retire seu cartão!");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente!");
                    break;
            }
        }
        while (opcao != "0");
    }
}
