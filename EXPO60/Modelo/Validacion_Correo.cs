using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace EXPO60.Modelo
{
    public abstract class Validacion_Correo
    {
        private SmtpClient smtpClient;
        protected string sendermail { get; set; }
        protected string password { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }
        protected bool ssl { get; set; }

        protected void initializesmtpclient()
        {
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(sendermail, password);
            smtpClient.Host = host;
            smtpClient.Port = port;
            smtpClient.EnableSsl = ssl;

        }

        public void sendmail(string subject, string body, List<string> recipientmail)
        {
            var mensaje = new MailMessage();
            try
            {
                mensaje.From = new MailAddress(sendermail);
                foreach (string mail in recipientmail)
                {
                    mensaje.To.Add(mail);
                }

                mensaje.Subject = subject;
                mensaje.Body = body;
                mensaje.Priority = MailPriority.Normal;
                smtpClient.Send(mensaje);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                mensaje.Dispose();

            }
        }
    }
}
