namespace CSharpCollections;

public class AulaListas
{
    public static void main()
    {
        var aulas = new List<string>();
        Console.WriteLine(aulas.Count); // Imprime a quantidade de elementos na lista (inicialmente 0)
        aulas.Add("Introdução ao C#"); // Adiciona um novo elemento à lista
        aulas.Add("Estruturas de Controle"); // Adiciona outro novo elemento
        aulas.Add("Estruturas de Repetição"); // Adiciona mais um novo elemento
        aulas.Add("Arrays e Coleções"); // Adiciona mais um novo elemento
        imprimir(aulas);
        Console.WriteLine(aulas.Count); // Imprime a quantidade de elementos na lista (inicialmente 0)

        Console.WriteLine("----------------------");
        Console.WriteLine(aulas.Contains("C#")); // Verifica se a lista contém o elemento "C#"
        Console.WriteLine(aulas.Contains("Introdução ao #")); // Verifica se a lista contém o elemento "Introdução ao CSharp"
        Console.WriteLine("----------------------");
        Console.WriteLine(aulas.Remove("Introdução ao C#")); // Remove o elemento "Introdução ao C#"
        imprimir(aulas); // Imprime a lista após a remoção
        Console.WriteLine("----------------------");
        aulas.Add("Introdução ao C#"); // Adiciona novamente o elemento "Introdução ao C#"
        Console.WriteLine(aulas.First()); // Imprime o primeiro elemento da lista
        Console.WriteLine(aulas.Last()); // Imprime o último elemento da lista

        Console.WriteLine("----------------------");
        Console.WriteLine("----------------------");
        Console.WriteLine("----------------------");

        Console.WriteLine(aulas.IndexOf("Introdução ao C#")); // Retorna o índice do elemento "Introdução ao C#"
        Console.WriteLine("----------------------");

        aulas.Insert(0, "Aula 1: Introdução ao C#"); // Insere um novo elemento no início da lista
        aulas.RemoveAt(4); // Remove o elemento no índice 3
        imprimir(aulas); // Imprime a lista após a inserção

        Console.WriteLine("----------------------");

        aulas.AddRange(new string[] { "Aula 5: Listas", "Aula 6: Dicionários" }); // Adiciona uma coleção de elementos à lista
        imprimir(aulas); // Imprime a lista após a adição

        Console.WriteLine("----------------------");
        Console.WriteLine(aulas.Exists(aula => aula.StartsWith("Aula 1"))); // Verifica se existe algum elemento que começa com "Aula 1"
        Console.WriteLine(aulas.Find(aula => aula.StartsWith("Aula 1"))); // Encontra o primeiro elemento que começa com "Aula 1"

        Console.WriteLine("----------------------");
        var aulas2 = aulas.GetRange(3, 2); // Obtém um intervalo de elementos da lista (do índice 3 ao 4)
        imprimir(aulas2); // Imprime o intervalo de elementos obtido
    }

    private static void imprimir(List<string> lista)
    {
        foreach (var item in lista)
        {
            Console.WriteLine(item);
        }
    }
}