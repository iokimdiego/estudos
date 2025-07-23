namespace CSharpCollections;

public class AulaArrays
{
    public static void main()
    {
        var aluno1 = "João";
        var aluno2 = "Maria";

        var alunos = new string[] { aluno1, aluno2, "Pedro", "Ana", "Lucas", "Fernanda", "Ana" };

        // alunos[0] = "João";
        // alunos[1] = "Maria";
        // alunos[2] = "Pedro";
        // alunos[3] = "Ana";
        // alunos[4] = "Lucas";

        // imprimir(alunos);

        Console.WriteLine(Array.IndexOf(alunos, "Ana")); // Retorna o índice do elemento "Ana"
        Console.WriteLine(Array.LastIndexOf(alunos, "Ana")); // Retorna o último índice do elemento "Ana"

        Console.WriteLine("----------------------");

        imprimir(alunos);

        Console.WriteLine("----------------------");

        Array.Reverse(alunos); // Inverte a ordem dos elementos no array
        imprimir(alunos);

        Console.WriteLine("----------------------");

        Array.Reverse(alunos); // Inverte novamente para restaurar a ordem original
        imprimir(alunos);

        Console.WriteLine("----------------------");

        Array.Resize(ref alunos, 10); // Redimensiona o array para 10 elementos
        alunos[7] = "Carlos"; // Adiciona um novo elemento
        alunos[8] = "Beatriz"; // Adiciona outro novo elemento
        alunos[9] = "Eduardo"; // Adiciona mais um novo elemento
        imprimir(alunos);

        Console.WriteLine("----------------------");
        Console.WriteLine("----------------------");
        Console.WriteLine("----------------------");

        var alunos2 = alunos; // Passagem de Referência ao mesmo array
        imprimir(alunos2);
        Console.WriteLine("----------------------");
        alunos[0] = "João Modificado"; // Modifica o primeiro elemento do array original
        imprimir(alunos2); // O array alunos2 também reflete essa modificação

        Console.WriteLine("----------------------");
        Console.WriteLine("----------------------");
        Console.WriteLine("----------------------");

        var alunosCopia = new string[2]; // Cria um novo array com 2 elementos
        Array.Copy(alunos, alunosCopia, 2); // Copia os primeiros 2 elementos do array original para o novo array
        imprimir(alunosCopia); // Imprime o array copiado
        Console.WriteLine("----------------------");
        alunos[0] = "João Modificado Novamente"; // Modifica o primeiro elemento do array original
        imprimir(alunosCopia); // O array copiado não reflete essa modificação, pois é uma cópia independente
        Console.WriteLine("----------------------");
        Array.Sort(alunosCopia); // Ordena o array em ordem alfabética
        imprimir(alunosCopia); // Imprime o array ordenado

    }

    private static void imprimir(string[] array)
    {
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}