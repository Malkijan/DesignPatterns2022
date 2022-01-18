using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Creational.AbstractFactory
{
    class OracleCommand : Command
    {
        public override void ExecuteCommand(string query)
        {
            // Gelen sorgunun çalıştırılması için
            // Gerekli operasyonel işlemler...
        }
    }
}
