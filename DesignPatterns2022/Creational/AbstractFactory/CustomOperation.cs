using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Creational.AbstractFactory
{
    class CustomOperation
    {
        IDatabaseFactory _databaseFactory;
        Connection _connection;
        Command _command;

        public CustomOperation(IDatabaseFactory databaseFactory)
        {
            _databaseFactory = databaseFactory;
            _command = databaseFactory.CreateCommand();
            _connection = databaseFactory.CreateConnection();
        }
        public void RemoveById(int id)
        {
            _connection.OpenConnection();
            _command.ExecuteCommand("Delete ...");
            _connection.CloseConnection();
        }
    }
}
