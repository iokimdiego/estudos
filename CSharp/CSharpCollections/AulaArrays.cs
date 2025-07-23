namespace CSharpCollections;

public class AulaArrays
{
    public static void main()
    {
        var alunos = new string[] {"João", "Maria", "Pedro", "Ana", "Lucas"};

        // alunos[0] = "João";
        // alunos[1] = "Maria";
        // alunos[2] = "Pedro";
        // alunos[3] = "Ana";
        // alunos[4] = "Lucas";

        imprimir(alunos);
    }

    private static void imprimir(string[] array)
    {
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}