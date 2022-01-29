using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Structural.Facade
{
    // Banka müşterimizi temsili oluşturan sınıf.
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
