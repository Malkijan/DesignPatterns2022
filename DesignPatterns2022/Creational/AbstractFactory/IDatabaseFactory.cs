using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Creational.AbstractFactory
{
    // Oluşturulacak ürünlere ait metotları içerir.
    // Oracle ve MySQL için bunların geriye döndüreceği
    // Nesneler farklı olacaktır.
    interface IDatabaseFactory
    {
        Connection CreateConnection();
        Command CreateCommand();
    }
}
