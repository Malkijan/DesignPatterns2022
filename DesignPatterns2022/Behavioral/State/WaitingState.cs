using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Behavioral.State
{
    // Farklı durumların meydana geldiği sınıf.
    class WaitingState : VendingMachineState
    {
        // WaitingState durumunda herhangi bir yeni duruma geçmeye gerek yok.
        // Buradan sonraki durum gelen istek ile aksiyon alacaktır.
        public override void HandleState(VendingMachine context)
        {
            Console.WriteLine("WaitingState: Otomata herhangi bir aksiyon bekliyor");
        }
    }
}
