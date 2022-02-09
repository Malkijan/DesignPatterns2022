using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Behavioral.State
{
    // Farklı durumların meydana geldiği sınıf.
    class PreparingState : VendingMachineState
    {
        // PreparingState durumunda ürün hazırlanması gibi işlemler yapılmaktadır.
        // Buradan sonraki durum ise ürünün verilmesi durumudur. (DeliveryState) 
        public override void HandleState(VendingMachine context)
        {
            Console.WriteLine("Preparing State: İstenilen ürün hazırlanıyor. Lütfen bekleyiniz.");

            context.SetState(new DeliveryState());
        }
    }
}
