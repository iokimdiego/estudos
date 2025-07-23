namespace CSharpCollections;

public class AulaFilas
{
    public static void main()
    {
        // Filas seguem o conceito FIFO (First In, First Out)
        // ou seja, o primeiro elemento adicionado é o primeiro a ser removido.

        var fila = new Queue<string>();

        fila.Enqueue("João"); // Adiciona João à fila
        fila.Enqueue("Maria"); // Adiciona Maria à fila
        fila.Enqueue("José"); // Adiciona José à fila
        imprimir(fila);

        fila.Dequeue(); // Remove o primeiro elemento (João)
        imprimir(fila);
    }
    
    private static void imprimir(Queue<string> fila)
    {
        Console.WriteLine("--------------------");
        Console.WriteLine("Fila atual:");
        foreach (var item in fila)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
}