namespace BlocoTryCatch;

class Program
{
    static void Main(string[] args)
    {
        // var nomes = new []{"João", "Maria", "José"};
        // for (var indice = 0; indice <= nomes.Length; indice++)
        // {
        //     //Console.WriteLine(nomes[indice]); // Esta linha causará uma exceção
        //     // A exceção será capturada pelo bloco try-catch abaixo
        //     try
        //     {
        //         Console.WriteLine(nomes[indice]);
        //     }
        //     catch (Exception excecao)
        //     {
        //         // if (excecao is IndexOutOfRangeException)
        //         // {
        //         //     continue; // Se a exceção for do tipo IndexOutOfRangeException, continue para o próximo índice
        //         //     break; // Se a exceção for do tipo IndexOutOfRangeException, interrompa o loop
        //         // }

        //         // Console.WriteLine($"Ocorreu um erro: {excecao.Message}"); // Captura a exceção e exibe a mensagem de erro
        //         // Console.WriteLine($"Ocorreu um erro: {excecao.StackTrace}"); // Exibe a pilha de chamadas da exceção
        //         // Console.WriteLine("Erro: Índice fora do intervalo dos nomes.");
        //     }
        // }

        // Hierarquia de exceções
        // try
        try
        {
            var soma = Convert.ToDecimal(Console.ReadLine());
            var quantdade = Convert.ToDecimal(Console.ReadLine());
            var media = soma / quantdade;
            Console.WriteLine($"A média calculada é: {media}");
        }
        // A hierarquia de exceções é a seguinte: do mais específico para o mais genérico ou abrangente
        catch (OverflowException)
        {
            Console.WriteLine("Erro: O número inserido é muito grande ou muito pequeno.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Erro: Divisão por zero não é permitida.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Formato inválido. Certifique-se de inserir números válidos.");
        }
        catch (Exception excecao)
        {
            Console.WriteLine($"Ocorreu um erro inesperado: {excecao.Message}");
        }
        finally
        {
            Console.WriteLine("Fim do programa.");
            // Este bloco é sempre executado, independentemente de uma exceção ter ocorrido ou não
            // O bloco finally é útil para liberar recursos, fechar conexões, etc.
            // Por exemplo, se você estiver trabalhando com arquivos ou conexões de banco de dados, pode fechá-los aqui
            // Console.WriteLine("Fim do programa.");
            // Console.WriteLine("Pressione qualquer tecla para sair...");
            // Encerra uma conexão com um banco de dados sql fictício:
                // Exemplo fictício:
                // if (conexao != null)
                // {
                //     conexao.Close();
                //     Console.WriteLine("Conexão com o banco de dados encerrada.");
                // }

        }
    }
}
