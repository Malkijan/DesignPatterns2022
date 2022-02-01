using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Structural.Bridge
{
    // Abstraction (Message) tarafından referansı tutulur ve haberleşme burası ile gerçekleşir.
    public interface IMessageSender
    {
        void SendMessage(Message message);
    }
}
