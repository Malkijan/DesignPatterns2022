using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Behavioral.Strategy
{
    // Sepette bulunan ürünleri temsil eden sınıf.
    // Ürün kodu ve fiyat bilgileri temel olarak yeterlidir.
    class Item
    {
        private string _upcCode;
        private int _price;

        public Item(string upcCode, int price)
        {
            _upcCode = upcCode; 
            _price = price;
        }

        public int GetPrice()
        {
            return _price;
        }
    }
}
