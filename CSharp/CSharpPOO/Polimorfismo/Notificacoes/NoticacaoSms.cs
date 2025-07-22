namespace Notificacoes
{
    public class NotificacaoSms : Notificacao
    {
        public NotificacaoSms(string destinatario, string mensagem) : base(destinatario, mensagem)
        {
        }

        public override void Enviar()
        {
            Console.WriteLine($"Enviando SMS para {Destinatário} com a mensagem: {Mensagem}");
            // Lógica para enviar o email
        }
    }
}