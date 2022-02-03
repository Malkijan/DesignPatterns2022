using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Behavioral.Command
{
    // Komutları nesneler haline getirelecek olan sınıf.
    class StockManager
    {
        private string _name;
        private int _quantity;

        public StockManager(string name, int quantity)
        {
            _name = name;
            _quantity = quantity;   
        }

        public void Buy()
        {
            Console.WriteLine($"Stock: {_name}, {_quantity} bought!");
        }
        public void Sell()
        {
            Console.WriteLine($"Stock: {_name}, {_quantity} sold!");
        }
    }
}
