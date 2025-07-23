using Itens;

namespace Interfaces;

class Program
{
    static void Main(string[] args)
    {
        var espada = new Espada("Excalibur", 10, 10, 100);
        espada.Colecionar();

        var pocao = new Pocao("Elixir da Vida", 20, 20, 50);
        pocao.Consumir();

        var joia = new Joia("Diamante", 30, 30, 100);
        joia.Colecionar();
        joia.Consumir();

        Console.WriteLine("--------------------------------------");

        //Polimorfismo com interfaces
        // IColecionavel item = new Espada("Lâmina do Destino", 5, 5, 200);
        // item.Colecionar();

        var itens = new List<Item>(); // Lista de itens
        itens.Add(espada);
        itens.Add(pocao);
        itens.Add(joia);

        foreach (var item in itens)
        {
            if (item is IColecionavel)
            {
                (item as IColecionavel).Colecionar(); // Chama o método Colecionar
            }
            if (item is IConsumivel)
            {
                (item as IConsumivel).Consumir(); // Chama o método Consumir
            }
            if (item is Espada)
            {
                Console.WriteLine($"A {item.Nome} está equipada!");
                Console.WriteLine($"A espada {item.Nome} causa danos de {(item as Espada).Dano} pontos!");
            }
        }
    }
}
