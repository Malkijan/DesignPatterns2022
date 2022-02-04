using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Behavioral.Iterator
{
    // Iterator arayüzünü uygulayan sınıf örneklerini elde etmek için metot içerir.
    // Bu sayede çeşitli Iterator arayüzünü uygulayan sınıfların örneklerini elde edebiliriz.
    interface IEmployeeAggregate
    {
        IIterator<Employee> Iterator();
    }
}
