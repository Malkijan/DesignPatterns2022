using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Behavioral.Visitor
{
    // Visitor arayüzünü ve burada tanımlı olan metotları uygular.
    // Sonradan eklenmek istenen işlemler burada yer alır.
    class XmlExportVisitor : IBookExportVisitor
    {
        public void ExportVisit(Magazine magazine)
        {
            // Parametre olarak gelen örneğin XML'e çevrilmesi işlemleri yer alacaktır.
            Console.WriteLine($"{magazine.name} exported by XmlExportVisitor");
        }

        public void ExportVisit(Encyclopedia encyclopedia)
        {
            // Parametre olarak gelen örneğin XML'e çevrilmesi işlemleri yer alacaktır.
            Console.WriteLine($"{encyclopedia.name} exported by XmlExportVisitor");
        }
    }
}
