using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Creational.AbstractFactory
{
    // MySQL için ilişkili nesneler üretildi.
    class MySQLDatabaseFactory : IDatabaseFactory
    {
        public Command CreateCommand()
        {
            return new MySQLCommand();
        }

        public Connection CreateConnection()
        {
            return new MySQLConnection();
        }
    }
}
