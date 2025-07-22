namespace Notificacoes
{
    public class NotificacaoEmail : Notificacao
    {
        public NotificacaoEmail(string destinatario, string mensagem) : base(destinatario, mensagem)
        {
        }

        public override void Enviar()
        {
            Console.WriteLine($"Enviando Email para {Destinatário} com a mensagem: {Mensagem}");
            // Lógica para enviar o email
        }
    }
}