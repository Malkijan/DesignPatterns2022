using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Behavioral.Observer
{
    // Observer sınıfından türer.
    class Samsung :ObservableProduct
    {
        // Ürün fiyatı değiştikten sonra Observer örneklerine bildirim gönderilir.
        public void ChangePrice()
        {
            // Ürün fiyatlarının güncellenmesi vs.

            this.message.productName = "Samsung";
            this.message.message = "Samsung price updated.";
            this.NotifyObserver();
        }
    }
}
