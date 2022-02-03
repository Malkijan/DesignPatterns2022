using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Behavioral.Command
{
    // Command (IOrderCommand) arayüzünü uygulayan sınıf referansını tutar.
    // Metotun ne zaman çağrılacağını belirtir.
    class StockController
    {
        private List<IOrderCommand> _orderCommands;

        public StockController()
        {
            _orderCommands = new List<IOrderCommand>();
        }

        public void TakeOrder(IOrderCommand command)
        {
            _orderCommands.Add(command);
        }
        public void PlaceOrders()
        {
            foreach (IOrderCommand command in _orderCommands)
            {
                command.Execute();
            }
            _orderCommands.Clear();
        }
    }
}
