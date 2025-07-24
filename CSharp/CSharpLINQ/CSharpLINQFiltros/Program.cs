namespace CSharpLINQFiltros;

class Program
{
    private static List<Despesa> despesas = new List<Despesa>
    {
        new Despesa { Descricao = "Aluguel", Valor = 1200.00m, Vencimento = new DateTime(2025, 7, 25) },
        new Despesa { Descricao = "Energia", Valor = 300.00m, Vencimento = new DateTime(2025, 7, 10) },
        new Despesa { Descricao = "Internet", Valor = 150.00m, Vencimento = new DateTime(2025, 7, 25) },
        new Despesa { Descricao = "Água", Valor = 100.00m, Vencimento = new DateTime(2025, 7, 20) }
    };
    static void Main(string[] args)
    {
        var despesasVencidas = from d in despesas
                                   //    where d.Vencimento < DateTime.Now // Filtra despesas vencidas
                               where d.Valor > 100.00m // Filtra despesas com valor maior que 100
                               orderby d.Vencimento descending, d.Valor // Ordena por vencimento decrescente e valor ascendente
                               select d;

        Console.WriteLine("Despesas Vencidas:");
        foreach (var despesa in despesasVencidas)
        {
            Console.WriteLine(despesa);
        }
    }
}
