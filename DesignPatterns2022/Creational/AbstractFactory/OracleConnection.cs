using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Creational.AbstractFactory
{
    class OracleConnection : Connection
    {
        public override bool CloseConnection()
        {
            // Oracle veri tabanı bağlantısının kapatılması için
            // Gerekli operasyonel işlemler...
            return true;
        }

        public override bool OpenConnection()
        {
            // Oracle veri tabanı bağlantısının açılması için
            // Gerekli operasyonel işlemler...
            return true;
        }
    }
}
