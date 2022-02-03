using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Behavioral.Command
{
    // Temel arayüzdür.
    // Komutların çalıştırılması için temel metotu içermektedir.
    interface IOrderCommand
    {
        void Execute();
    }
}
