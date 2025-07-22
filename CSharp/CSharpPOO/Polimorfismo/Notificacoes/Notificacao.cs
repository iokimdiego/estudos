namespace Notificacoes
{
    public abstract class Notificacao
    {
        public string Destinatário { get; set; }
        public string Mensagem { get; set; }

        public Notificacao(string destinatário, string mensagem)
        {
            Destinatário = destinatário;
            Mensagem = mensagem;
        }

        public abstract void Enviar();
    }
}