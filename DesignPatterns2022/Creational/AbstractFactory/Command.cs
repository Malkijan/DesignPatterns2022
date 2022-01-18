using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Creational.AbstractFactory
{
    public abstract class Command
    {
        public abstract void ExecuteCommand(string query);
    }
}
