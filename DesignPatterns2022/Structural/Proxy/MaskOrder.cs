using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Structural.Proxy
{
    // Maske siparişininin oluşturulduğu sınıf.
    // İstemcinin direkt erişmesini istemediğimiz alandır.
    class MaskOrder : IOrderableMask
    {
        public void CreateOrder(Person person)
        {
            // Burada siparişin oluşturulma işlemleri yer alacaktır.
            Console.WriteLine($"Order created to {person.Address}.");
        }
    }
}
