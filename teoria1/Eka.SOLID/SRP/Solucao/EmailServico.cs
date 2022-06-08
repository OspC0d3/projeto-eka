namespace SRP.Solucao;
public static class EmailServico
{
    public static bool EhValido(string email) => email.Contains("@");
    public static void Enviar(string de, string para, string assunto, string mensagem)
    {
        var mail = new MailMessage(de, para);
        var client = new SmtpClient
        {
            Port = 25,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Host = "smtp.google.com"
        };

        mail.Subject = assunto;
        mail.Body = mensagem;
        client.Send(mail);
    }
}
