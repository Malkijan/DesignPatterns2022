using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Structural.Bridge
{
    public class TextMessage : Message
    {
        // Abstraction (Message) sınıfından türer.
        public TextMessage(IMessageSender messageSender):base(messageSender)
        {

        }
        public override void Send()
        {
            messageSender.SendMessage(this);
        }
    }
}
