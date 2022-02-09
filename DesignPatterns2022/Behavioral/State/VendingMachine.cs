using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Behavioral.State
{
    // Durumu izlenecek olan sınıftır.
    public class VendingMachine
    {
        private VendingMachineState _state;
        
        // Otomata örneği oluştuğu zaman başlangıç durumuna geçiyor.
        public VendingMachine()
        {
            SetState(new InitializeState());
        }

        public void SetState(VendingMachineState state)
        {
            _state = state;
            _state.HandleState(this);
        }

        public void RequestProduct(string productName, double price)
        {
            // Burada ürünlere ait iş kodları olacaktır.
            // Ürün kontrolü, fiyatlandırma gibi kontroller.
            // Ürün ve fiyat olarak bir problemin olmadığı var sayılsın.

            SetState(new PreparingState());
        }
    }
}
