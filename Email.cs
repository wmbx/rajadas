using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace rajadas
{
    class Email
    {
        public void enviarEmail(String destinatarios, String assunto, String corpo)
        {
            try
            {
                SmtpClient smtp = new SmtpClient("smtp.office365.com", 587);

                smtp.UseDefaultCredentials = false;

                NetworkCredential credenciais = new NetworkCredential("vj14847@brscan.com.br", "Luca@160310");

                smtp.Credentials = credenciais;

                smtp.EnableSsl = true;

                MailMessage mensagemEmail = new MailMessage("walisson.benedito@brscan.com.br", destinatarios, assunto, corpo);
                
                smtp.Send(mensagemEmail);     
            }
            catch (Exception e)
            {
                throw;
            }
            

        }
    }
}
