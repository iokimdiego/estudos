namespace EstruturaCondicionalIf;

class Program
{
    static void Main(string[] args)
    {
        // var a = 3;
        // var b = 2;
        // // Verifica se a é maior que b   
        // if (a > b)
        // {
        //     Console.WriteLine($"{a} é maior que {b}");
        // }
        // else if (a < b)
        // {
        //     Console.WriteLine($"{a} é menor que {b}");
        // }
        // else
        // {
        //     Console.WriteLine($"{a} é igual a {b}");
        // }

        var idade = 19;

        if (idade >= 18)
        {
            Console.WriteLine("Você é maior de idade.");
            Console.WriteLine("Cadastro autorizado! ");
        }
        else if (idade >= 16)
        {
            Console.WriteLine("Menor de idade (> 16 anos)");
            Console.WriteLine("Cadastro autorizado com a presença dos responsáveis!");
        }
        else
        {
            Console.WriteLine("Menor de idade");
            Console.WriteLine("Cadastro não autorizado!");
        }

        Console.WriteLine("Finalizado!");
    }
}
