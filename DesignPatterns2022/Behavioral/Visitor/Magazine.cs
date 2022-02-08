using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Behavioral.Visitor
{
    // Accept metoduna bulunduğu nesne örneği gönderilir.
    class Magazine : Book
    {
        public override void Accept(IBookExportVisitor visitor)
        {
            visitor.ExportVisit(this);
        }
    }
}
