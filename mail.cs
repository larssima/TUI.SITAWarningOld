using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace DialogFinder
{
    class mail
    {
        public void SendMail(string mailaddresses)
        {
            var mail = new MailMessage("no-reply.rmserver@fritidsresor.se", mailaddresses);
            var client = new SmtpClient();
            client.Port = 25;
            //client.DeliveryMethod = SmtpDeliveryMethod.Network;
            //client.UseDefaultCredentials = false;
            client.Host = "smtp-relay.nordic.tuiad.org";
            mail.Subject = "SITA server is down!!";
            mail.Body = "Log into stospas75 and restart ASAP";
            client.Send(mail);
        }
    }
}
