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
    }
}
