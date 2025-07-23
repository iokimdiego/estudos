namespace Itens
{
    public class Joia : Item, IColecionavel, IConsumivel
    {
        public int Valor { get; set; }

        public Joia(string nome, int x, int y, int valor) : base(nome, x, y)
        {
            Valor = valor;
        }

        public void Colecionar()
        {
            // Implementação do método Colecionar
            Console.WriteLine($"Joia {Nome} (valor: {Valor} moedas) adicionada no inventário!");
        }

        public void Consumir()
        {
            // Implementação do método Consumir
            Console.WriteLine($"Joia {Nome} consumida! Você ganhou {Valor} moedas.");
        }
    }
}