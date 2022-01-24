using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Creational.Prototype
{
    // Klonlamak istediğimiz sınıflarımıza uygulayacağımız arayüz.
    // Farklı sınıflarda da kullanılması için Generic bir yapı oluşturuldu.
    // Generic yapı sayesinde dinamik olarak tip dönüşümü sağlanacaktır.
    // Bu sayede farklı sınıflara da bu deseni uygulama şansı doğuyor.
    interface ICloneablePrototype<TPrototype>
    {
        TPrototype Clone();
    }
}
