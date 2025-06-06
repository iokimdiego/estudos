namespace TrabalhandoComMetodos;

class Program
{
    class ContaCorrente
    {
        public string Numero;
        public decimal Saldo;

        public void ImprimirInformacoes()
        {
            Console.WriteLine($"Número da conta: {Numero} | Saldo: {Saldo}");
        }

        public string ListarInformacoes()
        {
            return $"Número da conta: {Numero} | Saldo: {Saldo}";
        }

        public void Depositar(decimal valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Depósito de {valor:C} realizado com sucesso. Novo saldo: {Saldo:C}");
            }
            else
            {
                Console.WriteLine("Valor de depósito inválido.");
            }
        }
    }
    static void Main(string[] args)
    {
        var conta1 = new ContaCorrente();
        conta1.Numero = "12345-6";
        conta1.Saldo = 0.00m;

        // Console.WriteLine($"Número da conta: {conta1.Numero} | Saldo: {conta1.Saldo}");

        // conta1.ImprimirInformacoes(); // Chamada do método para imprimir informações da conta
        Console.WriteLine(conta1.ListarInformacoes()); // Chamada do método para listar informações da conta

        conta1.Depositar(100); // Chamada do método para depositar dinheiro na conta
        Console.WriteLine(conta1.ListarInformacoes()); // Verifica o saldo após o depósito
    }
}
