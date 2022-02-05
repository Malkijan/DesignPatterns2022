using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Behavioral.Observer
{
    // Değişimden etkilenecek, izleyecek olan sınıfların uyguladığı arayüzdür.
    interface IObserverUser
    {
        void SendNotification(ProductUpdateMessage message);
    }
}
