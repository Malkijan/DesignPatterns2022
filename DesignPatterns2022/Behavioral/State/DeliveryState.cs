using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Behavioral.State
{
    // Farklı durumların meydana geldiği sınıf.
    class DeliveryState : VendingMachineState
    {
        // DeliveryState durumunda otomatadan ürünün teslim işlemleri yapılmaktadır.
        // Ürün verildikten sonra başlangıç, bekleme durumuna geçmektedir. (WaitingState)
        public override void HandleState(VendingMachine context)
        {
            Console.WriteLine("Delivery State: Ürün teslim ediliyor.");

            context.SetState(new WaitingState());
        }
    }
}
