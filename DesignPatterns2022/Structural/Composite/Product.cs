using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Structural.Composite
{
    // Somut yapımızdır.
    // Hiyerarşinin en alt tabakasını (Leaf) temsil etmektedir.
    class Product : ICatalogComponent
    {
        private string _name;

        public Product(string name)
        {
            _name = name;
        }
        public void DrawHierarchy()
        {
            Console.WriteLine(_name);
        }
    }
}
