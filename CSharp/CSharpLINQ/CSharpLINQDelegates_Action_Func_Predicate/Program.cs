namespace CSharpLINQDelegates_Action_Func_Predicate;

class Program
{
    static void Main(string[] args)
    {
        // Usando o Action com a definição tradicional do método ExibirInformacao
        // Action<string> exibir = ExibirInformacao;
        // exibir("Olá, Iokim!");

        // Usando o Action com uma expressão lambda parâmetro => corpo do método
        // Esta é uma forma mais concisa de definir o mesmo comportamento
        Action<string> exibir = informacao => Console.WriteLine($"Informação: {informacao}");
        exibir("Olá, Iokim!");

        // Usando o Func com uma definição de método tradicional
        // Func<int, int, int> realizarOperacao = Somar;
        // Console.WriteLine($"Resultado da soma: {realizarOperacao(5, 10)}");

        // Usando o Func com uma expressão lambda
        Func<int, int, int> realizarOperacao = (a, b) => a + b;
        Console.WriteLine($"Resultado da soma: {realizarOperacao(5, 10)}");

        // Usando o Predicate com uma definição de método tradicional
        // Predicate<int> verificar = EhPar;
        // Console.WriteLine($"O número 1 é par? {verificar(1)}");

        // Usando o Predicate com uma expressão lambda
        Predicate<int> verificar = a => a % 2 == 0; 
        Console.WriteLine($"O número 1 é par? {verificar(1)}");
    }

    // Definição do método ExibirInformacao
    // Esta é uma forma tradicional de definir um método que pode ser usado com Action
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
