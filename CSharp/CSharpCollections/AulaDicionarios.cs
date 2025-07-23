namespace CSharpCollections;

public class AulaDicionarios
{
    public static void main()
    {
        var alunos = new Dictionary<string, string>();
        alunos.Add("123", "João"); // Adiciona um novo aluno com chave "123"
        alunos.Add("456", "Maria");
        alunos["789"] = "Pedro"; // Adiciona ou atualiza o valor para a chave 789

        imprimir(alunos);
    }
    
    private static void imprimir(Dictionary<string, string> dicionario)
    {
        foreach (var item in dicionario)
        {
            Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
        }
    }
}