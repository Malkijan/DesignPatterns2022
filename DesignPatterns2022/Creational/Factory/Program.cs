using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Creational.Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotifyFactory notifyFactory = new NotifyFactory();

            INotify notify = notifyFactory.CreateNotify("MAIL");

            notify.SendNotification(new User());
        }
    }
}
