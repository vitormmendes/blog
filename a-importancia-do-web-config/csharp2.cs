var deEndereco = new System.Net.Mail.MailAddress("seuMail@gmail.com", "Vitor Mendes");
var paraEndereco = new System.Net.Mail.MailAddress("paraEmail@dominio.com", "To Name");

const string assunto = "Assunto";
const string corpoMensagem = "Teste de envio de e-mail";

var smtp = new System.Net.Mail.SmtpClient();

using (var message = new System.Net.Mail.MailMessage(deEndereco, paraEndereco))
{
    message.Subject = assunto;
    message.Body = corpoMensagem;

    smtp.Send(message);
}