using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Behavioral.Observer
{
    // Observer arayüzünü uygulayan, değişimi takip eden sınıflardır.
    // Değişim update metotu ile bildirilir.
    class ObserverUser : IObserverUser
    {
        public void SendNotification(ProductUpdateMessage message)
        {
            Console.WriteLine(message.ToString());
        }
    }
}
