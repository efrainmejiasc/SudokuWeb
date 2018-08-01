using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace SudokuWeb.Engine
{
    public class MailNotificacion
    {
        public bool EnviarMail(string asunto,string cuerpo,string mailCliente)
        {
            bool result = false;
            try
            {
                MailMessage mensaje = new MailMessage();
                SmtpClient servidor = new SmtpClient();
                mensaje.From = new MailAddress("sudokuparatodos@gmail.com");
                mensaje.Subject = asunto;
                mensaje.SubjectEncoding = System.Text.Encoding.UTF8;
                mensaje.Body = cuerpo;
                mensaje.BodyEncoding = System.Text.Encoding.UTF8;
                mensaje.IsBodyHtml = true;
                mensaje.To.Add(new MailAddress(mailCliente));
                //if (pathAdjunto != string.Empty) { mensaje.Attachments.Add(new Attachment(pathAdjunto)); }
                servidor.Credentials = new System.Net.NetworkCredential("sudokuparatodos", "1234santiago");
                servidor.Port = 587;
                servidor.Host = "smtp.gmail.com";
                servidor.EnableSsl = true;
                servidor.Send(mensaje);
                mensaje.Dispose();
                result = true;
            }
            catch
            {
            }

            return result;
        }

    }
}