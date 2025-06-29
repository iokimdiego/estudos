using Personagens;

namespace Heranca;

class Program
{
    static void Main(string[] args)
    {
        var cavaleiro = new Cavaleiro("Aragorn", 100);
        var arqueiro = new Arqueiro("Legolas", 100);

        cavaleiro.Atacar();
        cavaleiro.Defender();

        arqueiro.Atacar();
        arqueiro.Defender();
    }
}
