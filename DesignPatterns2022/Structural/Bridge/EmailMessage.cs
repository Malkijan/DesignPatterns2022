using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Structural.Bridge
{
    public class EmailMessage : Message
    {
        public EmailMessage(IMessageSender messageSender):base(messageSender)
        {

        }
        public override void Send()
        {
            messageSender.SendMessage(this);
        }
    }
}
