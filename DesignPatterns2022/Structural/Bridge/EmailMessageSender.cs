using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Structural.Bridge
{
    // Implementor arayüzünü (IMessageSender) uygular.
    public class EmailMessageSender : IMessageSender
    {
        public void SendMessage(Message message)
        {
            Console.WriteLine("Email Message Sender: Sending email message...");
        }
    }
}
