namespace Arrays;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = new int[3]; // Declarando um array de inteiros com 3 posições
        numeros[0] = 10; // Atribuindo valor à primeira posição
        numeros[1] = 20; // Atribuindo valor à segunda posição
        numeros[2] = 30; // Atribuindo valor à terceira posição
                         //numeros[2] = "30"; // Tentativa de atribuição de string a um array de inteiros (isso causará um erro de compilação)
                         //numeros[3] = 40; // Tentativa de atribuição fora dos limites do array (isso causará um erro de execução)
                         // Exibindo os valores do array
                         //Console.WriteLine(numeros[0]);
                         //Console.WriteLine(numeros[1]);
                         //Console.WriteLine(numeros[2]);
                         //Console.WriteLine(numeros[3]); // Descomente esta linha para ver o erro de execução

        int[] pares = new int[3] { 2, 4, 6 }; // Declarando e inicializando um array de inteiros com 3 posições
                                              // Exibindo os valores do array
                                              //Console.WriteLine(pares[0]);
                                              //Console.WriteLine(pares[1]);
                                              //Console.WriteLine(pares[2]);

        int[] impares = new int[] { 1, 3, 5, 7 }; // Declarando e inicializando um array de inteiros sem especificar o tamanho
                                                  // Exibindo os valores do array
                                                  // Console.WriteLine(impares[0]);
                                                  // Console.WriteLine(impares[1]);
                                                  // Console.WriteLine(impares[2]);
                                                  // Console.WriteLine(impares[3]);

        string[] nomes = new[] { "Ana", "Bruno", "Carlos" }; // Declarando e inicializando um array de strings sem especificar o tamanho
                                                             // Exibindo os valores do array
                                                             // Console.WriteLine(nomes[0]);
                                                             // Console.WriteLine(nomes[1]);
                                                             // Console.WriteLine(nomes[2]);

        string[] frutas = { "Maçã", "Banana", "Laranja" }; // Declarando e inicializando um array de strings sem especificar o tamanho
                                                           // Exibindo os valores do array
                                                           // Console.WriteLine(frutas[0]);
                                                           // Console.WriteLine(frutas[1]);
                                                           // Console.WriteLine(frutas[2]);
                                                            
        var cidades = new[] { "São Paulo", "Rio de Janeiro", "Belo Horizonte" }; // Declarando e inicializando um array de strings sem especificar o tipo
                                                                            // Exibindo os valores do array
                                                                            // Console.WriteLine(cidades[0]);
                                                                            // Console.WriteLine(cidades[1]);
                                                                            // Console.WriteLine(cidades[2]);
    }
}
