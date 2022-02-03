using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Behavioral.Command
{
    // Nesnelere dönüştürdüğümüz her bir isteğe denk gelmektedir.
    // Command (IOrderCommand) arayüzünü uygular.
    class SellStock : IOrderCommand
    {
        private StockManager _stockManager;

        public SellStock(StockManager stockManager)
        {
            _stockManager = stockManager;
        }
        public void Execute()
        {
            _stockManager.Sell();
        }
    }
}
