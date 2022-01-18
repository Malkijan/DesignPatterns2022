using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Creational.AbstractFactory
{
    class MySQLConnection : Connection
    {
        public override bool CloseConnection()
        {
            // MySQL veri tabanı bağlantısının kapatılması için
            // Gerekli operasyonel işlemler...
            return true;
        }

        public override bool OpenConnection()
        {
            // MySQL veri tabanı bağlantısının kapatılması için
            // Gerekli operasyonel işlemler...
            return true;
        }
    }
}
