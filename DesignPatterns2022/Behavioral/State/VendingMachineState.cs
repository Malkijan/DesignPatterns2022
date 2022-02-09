using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Behavioral.State
{
    // Davranışların tanımlandığı soyut sınıftır.
    public abstract class VendingMachineState
    {
        public abstract void HandleState(VendingMachine context);
    }
}
