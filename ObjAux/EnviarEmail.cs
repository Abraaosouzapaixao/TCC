using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bistro.ObjAux
{
    class EnviarEmail
    {

        // Certifique-se que seu GMAIL esteja habilitado para envio de e-mail.
        // https://myaccount.google.com/lesssecureapps

        /// <summary>
        /// Função responsável por enviar um e-mail a partir da configuração feita na função ConfigurarCredenciais
        /// </summary>
        /// <param name="emailPara">E-mail para enviar a mensagem</param>
        /// <param name="assunto">Assunto do e-mail</param>
        /// <param name="mensagem">Mensagem do e-mail</param>
        public void Enviar(string emailPara, string assunto, string mensagem)
        {
            Task.Factory.StartNew(() =>
            {
                System.Net.Mail.MailMessage email = new System.Net.Mail.MailMessage();

                string remetente = "abraasouzap@gmail.com";
                string senha = "fusca79*";

                // Configura Remetente, Destinatário
                email.From = new System.Net.Mail.MailAddress(remetente);
                email.To.Add(emailPara);

                // Configura Assunto, Corpo e se o Corpo está em Html
                email.Subject = assunto;
                email.Body = mensagem;
                email.IsBodyHtml = true;

                // Configura os parâmetros do objeto SMTP
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;

                // Atribui credenciais
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential(remetente, senha);

                // Envia a mensagem
                smtp.Send(email);
            });
        }
    }
}
