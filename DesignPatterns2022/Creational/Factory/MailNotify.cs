using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Creational.Factory
{
    internal class MailNotify : INotify
    {
        public void SendNotification(User user)
        {
            Console.WriteLine("Kullanıcıya mail gönderildi.");
            // Mail gönderme operasyonu.
        }
    }
}
