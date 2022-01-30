using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Structural.Proxy
{
    // Sipariş işlemlerini gerçekleştiren sınıflar tarafından uygulanan arayüz.
    interface IOrderableMask
    {
        void CreateOrder(Person person);
    }
}
