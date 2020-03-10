using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DentApexis.COMMON.Helpers
{
   public static class Mailer
    {
        public static void Send(string reciever,string body,string subject)
        {
            string sender = "mailadresi@mail.com";
            string password = @"buraya şifre gelecek";
            MailAddress senderEmail = new MailAddress(sender);
            MailAddress receiverEmail = new MailAddress(reciever);

            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(senderEmail.Address, password)

            };

            using (var mesaj =new MailMessage(senderEmail,receiverEmail)
            {
                Subject=subject,
                Body = body


            })
            {
                smtp.Send(mesaj);
                
            }

        }



    }
}
