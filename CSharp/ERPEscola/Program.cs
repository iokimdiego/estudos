Console.WriteLine("=== SISTEMA ERP ESCOLA ===");

Console.Write("Digite seu nome: ");
string nome = Console.ReadLine(); // Lendo a entrada do usuário como string

Console.Write("Digite sua idade: ");
// int idade = int.Parse(Console.ReadLine()); // Convertendo a entrada de string para inteiro.
// Dá erro se o usuário digitar algo que não seja um número inteiro. Ex: "vinte" ou "20.5". Para evitar isso, poderíamos usar int.TryParse() para validar a entrada.

int idade = 0; // Variável para armazenar a idade do usuário, inicializada com um valor padrão (0) para evitar erros de compilação.
bool idadeValida = false; // Variável para controlar se a idade é válida ou não

while (!idadeValida) // Loop para garantir que o usuário digite uma idade válida
{
    Console.Write("Digite sua idade: ");
    string entrada = Console.ReadLine();

    if (int.TryParse(entrada, out idade)) // Tentando converter a entrada para inteiro
    {
        idadeValida = true; // Se a conversão for bem-sucedida, a idade é válida
    }
    else
    {
        Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro para a idade."); // Mensagem de erro para entrada inválida
    }
}

Console.WriteLine($"Bem-vindo, {nome}! Você tem {idade} anos."); // Exibindo a mensagem de boas-vindas com o nome e idade do usuário

//Tarefa 3