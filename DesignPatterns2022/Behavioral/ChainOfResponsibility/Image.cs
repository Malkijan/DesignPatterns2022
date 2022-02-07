using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Behavioral.ChainOfResponsibility
{
    // Uygulama süresince resimlerimizi temsil edecek sınıf.
    class Image
    {
        public string name;
        public string extension;

        public Image(string name, string extension)
        {
            this.name = name;
            this.extension = extension;
        }
    }
}
