using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Behavioral.Observer
{
    // Bildirilecek olan nesnelere paremetre olarak giden mesaj.
    class ProductUpdateMessage
    {
        public string productName;
        public string message;

        public override string ToString()
        {
            return $"{productName} updated. Message: {message}";
        }
    }
}
