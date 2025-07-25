namespace CSharpLINQDelegates_Action_Func_Predicate;

class Program
{
    static void Main(string[] args)
    {
        Action<string> exibir = ExibirInformacao;
        exibir("Olá, Iokim!");

        Func<int, int, int> realizarOperacao = Somar;
        Console.WriteLine($"Resultado da soma: {realizarOperacao(5, 10)}");

        Predicate<int> verificar = EhPar;
        Console.WriteLine($"O número 1 é par? {verificar(1)}");
    }

    static void ExibirInformacao(string informacao)
    {
        Console.WriteLine($"Informação: {informacao}");
    }

    static int Somar(int a, int b)
    {
        return a + b;
    }

    static bool EhPar(int a)
    {
        return a % 2 == 0;
    }  
}
