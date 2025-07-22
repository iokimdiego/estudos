using Notificacoes;

namespace Polimorfismo;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Selecione o tipo de notificação: 1 - Email | 2 - SMS | 3 - Whatsapp");
        var tipo = Console.ReadLine();

        Console.WriteLine("Informe o Destinatário:");
        var destinatario = Console.ReadLine();

        Console.WriteLine("Informe a Mensagem:");
        var mensagem = Console.ReadLine();


        Notificacao notificacao;
        //Notificação é uma classe pai abstrata, então não podemos instanciá-la diretamente

        notificacao = new NotificacaoEmail(destinatario, mensagem);

        switch (tipo)
        {
            case "1":
                notificacao = new NotificacaoEmail(destinatario, mensagem);
                break;
            case "2":
                notificacao = new NotificacaoSms(destinatario, mensagem);
                break;
            case "3":
                notificacao = new NotificacaoWhatsApp(destinatario, mensagem);
                break;
            default:
                notificacao = new NotificacaoEmail(destinatario, mensagem);
                break;
        }

        notificacao.Enviar();
    }
}
