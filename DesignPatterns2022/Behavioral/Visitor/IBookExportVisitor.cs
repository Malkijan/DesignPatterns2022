using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Behavioral.Visitor
{
    // Her ConcreteVisitor örneği için metot temsil eder.
    // Parametre olarak Element sınıfından türeyen sınıfların örneğini alır.
    interface IBookExportVisitor
    {
        void ExportVisit(Magazine magazine);
        void ExportVisit(Encyclopedia encyclopedia);
    }
}
