namespace OlaMundo;

class Program
{
    static void Main(string[] args)
    {
        //int idade;
        //idade = 21;

        // o tipo var só é definido quando atribuimos o primeiro valor. Exemplo: A variável nome é do tipo string
        //var nome = "Iokim";

        int ano = 2025;
        double ano2 = ano; // Conversão implícita de int para double
                           // int ano3 = ano2; // Comentário: Conversão implícita de double para int não é permitida
        int ano3 = (int)ano2; // Conversão explícita de double para int

        decimal taxa = 12.98m; // O sufixo 'm' indica que é um decimal
                               // string taxa = (string)taxa; // Conversão explícita inválida de decimal para string
                               // Comentário: A conversão de decimal para string não é válida, pois decimal não pode ser convertido diretamente para string
        string taxaString = taxa.ToString(); // Conversão explícita de decimal para string

        string resposta = "12";
        int idade = int.Parse(resposta); // Conversão de string para int
        int idade2 = Convert.ToInt32(resposta); // Outra forma de conversão de string para int

        var nome = "Iokim"; // O tipo var é inferido como string
        var sobrenome = "Silva"; // O tipo var é inferido como string

        var nomeCompleto = nome + " " + sobrenome; // Concatenação de strings
        //Console.WriteLine(nomeCompleto);

        // Outra forma de concatenação de strings
        var nomeCompleto2 = $"{nome} {sobrenome}"; // Interpolação de strings
        //Console.WriteLine(nomeCompleto2); // Exibe a interpolação de strings

        Console.WriteLine(nomeCompleto.ToUpper()); // Converte o nome completo para letras maiúsculas
        Console.WriteLine(nomeCompleto.ToLower()); // Converte o nome completo para letras minúsculas
        Console.WriteLine(nomeCompleto.Substring(4)); // Extrai uma substring a partir do índice 4 (até o final). Resultado: "m Silva"
        Console.WriteLine(nomeCompleto.Substring(4, 5)); // Extrai uma substring a partir do índice 4 com comprimento 5. Resultado: "m Sil"
        Console.WriteLine(nomeCompleto.IndexOf("i")); // Encontra o índice da primeira ocorrência do caractere 'i'. Resultado: 4
        Console.WriteLine(nomeCompleto.LastIndexOf("i")); // Encontra o índice da última ocorrência do caractere 'i'. Resultado: 6
        Console.WriteLine(nomeCompleto.Contains('o')); // Verifica se o nome completo contém o caractere 'o'. Resultado: True
        Console.WriteLine(nomeCompleto.Contains("Silva")); // Verifica se o nome completo contém a substring "Silva". Resultado: True
        Console.WriteLine(nomeCompleto.Contains("Fa")); // Verifica se o nome completo contém a substring "Fa". Resultado: False
        Console.WriteLine(nomeCompleto.StartsWith("Iokim")); // Verifica se o nome completo começa com "Iokim". Resultado: True
        Console.WriteLine(nomeCompleto.EndsWith("Martins")); // Verifica se o nome completo termina com "Martins". Resultado: False
        Console.WriteLine(nomeCompleto.Length); // Exibe o comprimento do nome completo. Resultado: 11

    }
}
