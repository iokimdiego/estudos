using Financeiro;
using RH;

namespace DefinindoNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var contaPagar = new ContaPagar();
            var contaReceber = new ContaReceber();
            var funcionario = new Funcionario();
            var folhaPagamento = new RH.FolhaPagamento(); //Para evitar ambiguidade, especificamos o namespace completo
            // Se não especificarmos o namespace completo, o compilador não saberá qual FolhaPagamento usar
            
            Console.WriteLine("Hello, World!");
        }
    }

}

