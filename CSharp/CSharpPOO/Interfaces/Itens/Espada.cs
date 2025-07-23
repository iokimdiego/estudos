namespace Itens
{
    public class Espada : Item, IColecionavel
    {
        public int Dano { get; set; }

        public Espada(string nome, int x, int y, int dano) : base(nome, x, y)
        {
            Dano = dano;
        }

        public void Colecionar()
        {
            // Implementação do método Colecionar
            Console.WriteLine($"Espada {Nome} (dano: {Dano}pts) adicionada no inventário!");
        }
    }
}