using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Behavioral.ChainOfResponsibility
{
    // JPG dosyalarını dönüştüren sınıf.
    class JPGHandler : BaseHandler
    {
        public override void HandleRequest(Image image)
        {
            if (image.extension=="JPG")
            {
                Console.WriteLine("JPG to PNG");
                // JPG işlemine ait dönüştürme kodları işlemleri.
            }
            else
            {
                // Bu sınıfa ait bir işlem değilse zincirin bir sonraki halkasına aktarılır.
                _nextHandler.HandleRequest(image);
            }
        }
    }
}
