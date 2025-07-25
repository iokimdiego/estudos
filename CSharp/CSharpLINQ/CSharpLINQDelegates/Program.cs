namespace CSharpLINQDelegates;

delegate void ExibirMensagem(string texto);

public delegate void Notificacao(string mensagem);
class Program
{
    static void Main(string[] args)
    {
        // ExibirMensagem exibir = ExibirInformacao;

        // exibir("Bem-vindo ao C# com Delegates!");

        // exibir = ExibirErro;
        // exibir("Ocorreu um erro ao processar a solicitação.");

        // Criando o multicast delegate
        Notificacao notificacao = new Notificacao(NotificarPorEmail); // Inicializando com o método de notificação por e-mail
        notificacao += NotificarPorWhatsApp; // Adicionando delegate para WhatsApp
        notificacao += NotificarPorSMS; // Adicionando delegate para SMS

        // Invocando o multicast delegate
        notificacao("Sua conta foi criada com sucesso!");
    }

    static void ExibirInformacao(string informacao)
    {
        Console.WriteLine($"Informação: {informacao}");
    }

    static void ExibirErro(string informacao)
    {
        Console.WriteLine($"Erro: {informacao}");
    }

    static void NotificarPorEmail(string mensagem)
    {
        Console.WriteLine($"Enviando por e-mail: { mensagem }");
    }

    static void NotificarPorWhatsApp(string mensagem)
    {
        Console.WriteLine($"Enviando por WhatsApp: { mensagem }");
    }

    static void NotificarPorSMS(string mensagem)
    {
        Console.WriteLine($"Enviando por SMS: { mensagem }");
    }
}
