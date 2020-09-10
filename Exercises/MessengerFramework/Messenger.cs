using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MessengerFramework
{
    public class Messenger
    {
        public void Send (string to,string body,string subject)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("sergiusanduta86@gmail.com");
                mail.To.Add(to);
                mail.Subject = subject;
                mail.Body = body;

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    
                    smtp.Credentials = new NetworkCredential("sergiusanduta86@gmail.com", "Sergiu_1986");
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                   
                }


            }
        }
    }
}
