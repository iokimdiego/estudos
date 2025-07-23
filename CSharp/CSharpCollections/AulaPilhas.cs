namespace CSharpCollections;

public class AulaPilhas
{
    public static void main()
    {
        // Pilhas seguem o conceito LIFO (Last In, First Out)
        // ou seja, o último elemento adicionado é o primeiro a ser removido.

        var pilha = new Stack<string>();

        pilha.Push("João"); // Adiciona João à pilha
        pilha.Push("Maria"); // Adiciona Maria à pilha
        pilha.Push("José"); // Adiciona José à pilha
        imprimir(pilha);

        pilha.Pop(); // Remove o último elemento (José)

        imprimir(pilha);
    }
    private static void imprimir(Stack<string> pilha)
    {
        Console.WriteLine("Elementos na pilha:");
        foreach (var item in pilha)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine($"Total de elementos na pilha: {pilha.Count}");
        Console.WriteLine();
    }
}