using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Behavioral.Visitor
{
    // Temel sınıftır.
    // Yeni davranışları Accept metotu ile alır.
    abstract class Book
    {
        public string name;
        public string author;
        public string categoryName;

        public abstract void Accept(IBookExportVisitor visitor);
    }
}
