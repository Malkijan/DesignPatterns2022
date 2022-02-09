using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Behavioral.State
{
    // Farklı durumların meydana geldiği sınıf.
    class InitializeState : VendingMachineState
    {
        // Başlangıç durumu ayarları yapıldıktan sonra WaitingState (hazır) durumuna geçer.
        public override void HandleState(VendingMachine context)
        {
            Console.WriteLine("InitializeState: Ön hazırlıklar yapılıyor");

            context.SetState(new WaitingState());
        }
    }
}
