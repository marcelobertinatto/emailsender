using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmailSender
{
    class Program
    {
        static void Main(string[] args)
        {
       
            GmailClientInfo client = new GmailClientInfo() {
                 GmailUserEmail= "jvssbrito@gmail.com",
                 GmailUserPassword= "mwkevjfatwzqrdpg",                  
            };

            IEmailSender GmailSender = new GmailEmailSender(client);

            EmailMessage Message = new EmailMessage()
            {
                TO = new List<string>() { "marcelobertinatto@hotmail.com" },
                CC=null,
                Subject="Test Email",
                Body="This is test Email.",
                IsBodyHtml=false
            };

            EmailSendResult Result = GmailSender.SendEmail(Message);
            if(Result.IsMessageDelivered)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Email Is Delivered!");
                Console.ReadLine();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                string error = string.Format("Email is not delivered due to following error \r\n{0}", Result.Error.Message);
                Console.WriteLine(error);
            }
        }
    }
}
