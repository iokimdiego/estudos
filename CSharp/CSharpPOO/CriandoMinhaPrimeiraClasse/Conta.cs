// namespace CriandoMinhaPrimeiraClasse
namespace Contas
{
    public class Conta
    {
        // Atributos da classe Conta
        // Atributos são as características que definem a classe
        public static double TaxaRendimento = 0.05f; // Atributo estático que representa a taxa de rendimento da conta
        // Atributos de instância
        public string Numero = "";
        public DateTime DataAbertura;
        public decimal Saldo;

        // Métodos da classe Conta
        // Métodos são as ações que a classe pode realizar

        // O primeiro método é o construtor da classe, que é chamado quando um objeto da classe é criado
        public Conta() // Construtor padrão da classe Conta
        {
            Numero = DateTime.Now.ToString("yyyyMMddHHmmss"); // Gera um número de conta baseado na data e hora atual
            DataAbertura = DateTime.Now; // Define a data de abertura como a data e hora atual
            Saldo = 0; // Define o saldo inicial como zero
            // Não recebe parâmetros e não retorna nada
            // Inicializa os atributos com valores padrão
        }
        public Conta(string numero, DateTime dataAbertura, decimal saldo) // Construtor com parâmetros
        {
            Numero = numero; // Atribui o número da conta
            DataAbertura = dataAbertura; // Atribui a data de abertura
            Saldo = saldo; // Atribui o saldo inicial
            // Recebe os valores dos atributos como parâmetros e os inicializa
        }

        // public void ExibirExtrato() // Método para exibir o extrato da conta no console
        // // Não recebe parâmetros e não retorna nada
        // {
        //     Console.WriteLine("===================================");
        //     Console.WriteLine($"Número da Conta:..........{Numero}");
        //     Console.WriteLine($"Data de Abertura:.........{DataAbertura.ToShortDateString()}");
        //     Console.WriteLine($"Saldo Atual:..............{Saldo:C}"); // Formata o saldo como moeda
        //     Console.WriteLine("===================================");
        // }
        public string ExibirExtrato() // Método para exibir o saldo da conta no console
        // Não recebe parâmetros e retorna o saldo formatado como string     
        {
            // Console.WriteLine("===================================");
            return $"=================================== {Environment.NewLine}" +
                   $"Número da Conta:..........{Numero}{Environment.NewLine}" + // Environment.NewLine adiciona uma quebra de linha
                   $"Data de Abertura:.........{DataAbertura.ToShortDateString()}{Environment.NewLine}" +
                   $"Saldo Atual:..............{Saldo:C}{Environment.NewLine}" + // Formata o saldo como moeda
                   "===================================";
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

        // Sobrecarga do método RealizarEmprestimo
        public void RealizarEmprestimo(decimal valor)
        {
            Saldo += valor;
            Console.WriteLine($"O valor de {valor:C} foi creditado e será debitado dentro de 30 dias.");
        }
        public void RealizarEmprestimo(decimal valor, int parcelas)
        {
            Saldo += valor;
            Console.WriteLine($"O valor de {valor:C} foi creditado e será debitado em {parcelas} vezes.");
        }

        public static double CalcularRendimento(double capital, int meses)
        {
            // Método estático para calcular o rendimento de um capital investido por um determinado número de meses
            // Recebe o capital e o número de meses como parâmetros e retorna o rendimento calculado
            return capital * Math.Pow(1 + TaxaRendimento, meses);
        }

    }
}