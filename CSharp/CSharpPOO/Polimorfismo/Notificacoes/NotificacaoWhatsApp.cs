namespace Notificacoes
{
    public class NotificacaoWhatsApp : Notificacao
    {
        public NotificacaoWhatsApp(string destinatario, string mensagem) : base(destinatario, mensagem)
        {
        }

        public override void Enviar()
        {
            Console.WriteLine($"Enviando mensagem via WhatsApp para {Destinatário} com a mensagem: {Mensagem}");
            // Lógica para enviar o email
        }
    }
}