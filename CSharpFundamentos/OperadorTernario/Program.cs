namespace OperadorTernario;

class Program
{
    static void Main(string[] args)
    {
        var mensagem = "";
        var nota = 9;
        // Usando operador ternário para verificar a nota

        //CONDIÇÃO ? SE FOR VERDADEIRO : SE FOR FALSO
        mensagem = nota >= 7 ? "Aprovado" : "Reprovado";

        Console.WriteLine(mensagem);
        
    }
}
