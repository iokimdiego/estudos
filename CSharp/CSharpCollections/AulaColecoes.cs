namespace CSharpCollections;

public class AulaColecoes
{
    public static void main()
    {
        var alunos = new HashSet<string>();

        alunos.Add("João");
        alunos.Add("Maria");
        alunos.Add("Pedro");
        alunos.Add("Maria"); // Tentativa de adicionar um elemento duplicado, não será adicionado

        imprimir(alunos); // Imprime os elementos do HashSet
    }

    private static void imprimir(HashSet<string> set)
    {
        foreach (var item in set)
        {
            Console.WriteLine(item);
        }
    }
}