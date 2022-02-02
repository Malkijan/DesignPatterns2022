using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Behavioral.Strategy
{
    // Benzer işlemleri yapan sınıflar bu arayüzden türeyecektir.
    interface IPayment
    {
        void Pay(int amount);
    }
}
