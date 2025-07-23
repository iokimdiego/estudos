namespace CSharpCollections;

public class AulaListasLigadas
{
    public static void main()
    {
        // [1] <-> [2] <-> [3] <-> [4]
        // Cada elemento aponta para o próximo, formando uma cadeia
        var listaLigada = new LinkedList<string>(); // Cria uma lista ligada de strings

        // [Primeira Posição] -> []
        var node1 = listaLigada.AddFirst("Primeira Posição"); // Adiciona o primeiro elemento

        // [Primeira Posição] <-> [Segunda Posição]
        var node2 = listaLigada.AddAfter(node1, "Segunda Posição"); // Adiciona depois do primeiro elemento

        // [Primeira Posição] <-> [Terceira Posição] <-> [Segunda Posição]
        var node3 = listaLigada.AddBefore(node2, "Terceira Posição"); // Adiciona antes do segundo elemento

        // [Primeira Posição] <-> [Terceira Posição] <-> [Segunda Posição] <-> [Quarta Posição]
        // O último elemento não aponta para nada, formando o final da lista
        var node4 = listaLigada.AddLast("Quarta Posição"); // Adiciona o último elemento

        Console.WriteLine("Lista ligada após adição:");
        // Console.WriteLine(node1.Next?.Value); // Imprime o segundo elemento
        // Console.WriteLine(node2.Previous?.Value); // Imprime o primeiro elemento
        imprimir(listaLigada); // Imprime todos os elementos da lista ligada

        Console.WriteLine("-------------------------");

        // Removendo elementos
        listaLigada.RemoveFirst(); // Remove o primeiro elemento
        Console.WriteLine("Lista ligada após remoção do primeiro elemento:");
        imprimir(listaLigada); // Imprime a lista após remoção

        Console.WriteLine("-------------------------");
        // Removendo o último elemento
        listaLigada.RemoveLast(); // Remove o último elemento
        Console.WriteLine("Lista ligada após remoção do último elemento:");
        imprimir(listaLigada); // Imprime a lista após remoção

        Console.WriteLine("-------------------------");
        // Removendo um elemento específico
        listaLigada.Remove(node3); // Remove o terceiro elemento
        listaLigada.Remove("Terceira Posição"); // Também pode ser removido pelo valor
        // Se o elemento não existir, nada acontece
        Console.WriteLine("Lista ligada após remoção do node3:");
        imprimir(listaLigada); // Imprime a lista após remoção
    }
    private static void imprimir(LinkedList<string> lista)
    {
        foreach (var item in lista)
        {
            Console.WriteLine(item); // Imprime cada item da lista ligada
        }
    }
}