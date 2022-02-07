using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Behavioral.ChainOfResponsibility
{
    // JPEG dosyalarını dönüştüren sınıf.
    class JPEGHandler : BaseHandler
    {
        public override void HandleRequest(Image image)
        {
            if (image.extension=="JPEG")
            {
                Console.WriteLine("JPEG to PNG");
                // JPEG işlemine ait dönüştürme kodları işlemleri.
            }
            else
            {
                // Bu sınıfa ait bir işlem değilse zincirin bir sonraki halkasına aktarılır.
                _nextHandler.HandleRequest(image);
            }
        }
    }
}
