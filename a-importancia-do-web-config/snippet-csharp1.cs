var deEndereco = new System.Net.Mail.MailAddress("seuEmail@gmail.com", "Nome");
var paraEndereco = new System.Net.Mail.MailAddress("emailPara@dominio.com", "Nome");

const string senha = "Senha";
const string assunto = "Assunto";
const string corpoMensagem = "Teste de envio de e-mail";

var smtp = new System.Net.Mail.SmtpClient
{
    Host = "smtp.gmail.com",
    Port = 587,
    EnableSsl = true,
    DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
    UseDefaultCredentials = false,
    Credentials = new System.Net.NetworkCredential(deEndereco.Address, senha)
};

using (var message = new System.Net.Mail.MailMessage(deEndereco, paraEndereco))
{
    message.Subject = assunto;
    message.Body = corpoMensagem;

    smtp.Send(message);
}