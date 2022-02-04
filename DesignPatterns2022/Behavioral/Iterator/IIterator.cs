using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Behavioral.Iterator
{    // Koleksiyon üzerinde dolaşmak için operasyonların tanımlandığı arayüzdür.
    // Bir sonraki elemana geçme, bir sonraki elemanın olup olmadığı gibi.
    // Generic bir yapı sağlanarak birçok yerde kullanılması sağlanır.
    interface IIterator<T>
    {
        bool HasNext();
        T GetCurrentItem();
    }
}
