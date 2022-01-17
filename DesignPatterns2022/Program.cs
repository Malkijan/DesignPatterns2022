using DesignPatterns2022.Creational.Factory;
using DesignPatterns2022.Creational.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Singleton
            Database firstInstanceRequest = Database.GetInstance();
            Database secondInstanceRequest = Database.GetInstance();

            bool isEquals = firstInstanceRequest == secondInstanceRequest;

            Console.WriteLine($"Database referance is equals: {isEquals}"); //output: Database referance is equals: True
            #endregion

            #region Factory
            NotifyFactory notifyFactory = new NotifyFactory();

            INotify notify = notifyFactory.CreateNotify("MAIL");

            notify.SendNotification(new User());
            #endregion
        }
    }

}
