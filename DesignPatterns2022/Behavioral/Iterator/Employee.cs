using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Behavioral.Iterator
{
    // Liste üzerinde gezilecek olan elamnı temsil eden sınıf.
    class Employee
    {
        public int id;
        public string firstName;
        public string lastName;

        public Employee(int id, string firstName, string lastName)
        {
            this.id = id;   
            this.firstName = firstName; 
            this.lastName = lastName;
        }
    }
}
