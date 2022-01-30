using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Structural.Proxy
{
    // Maske siparişini verecek kullanıcıları temsili sınıf.
    class Person
    {
        public string TC { get; set; }
        public string Address { get; set; }

        public Person(string tc, string address)
        {
            this.TC = tc;
            this.Address = address;
        }
    }
}
