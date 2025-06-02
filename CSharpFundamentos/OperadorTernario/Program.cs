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
        // explique o que foi feito no código, em poucas palavras e em inglês técnico
        // The code uses a ternary operator to assign a message based on the value of 'nota'.
    }
}
