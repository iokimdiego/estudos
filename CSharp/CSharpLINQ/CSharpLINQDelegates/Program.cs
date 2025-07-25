namespace CSharpLINQDelegates;

delegate void ExibirMensagem(string texto);
class Program
{
    static void Main(string[] args)
    {
        ExibirMensagem exibir = ExibirInformacao;

        exibir("Bem-vindo ao C# com Delegates!");

        exibir = ExibirErro;
        exibir("Ocorreu um erro ao processar a solicitação.");
    }

    static void ExibirInformacao(string informacao)
    {
        Console.WriteLine($"Informação: {informacao}");
    }

    static void ExibirErro(string informacao)
    {
        Console.WriteLine($"Erro: {informacao}");
    }
}
