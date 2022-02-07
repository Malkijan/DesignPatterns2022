using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Behavioral.ChainOfResponsibility
{
    // Herhangi bir tipteki dosyayı dönüştüren sınıf.
    class CustomHandler : BaseHandler
    {
        public override void HandleRequest(Image image)
        {
            if (image.extension=="OtherExtension")
            {
                Console.WriteLine("OtherExtension to PNG");
                // Herhangi bir tipteki dosyanın işlemine ait dönüştürme kodları işlemleri.
            }
            else
            {
                // Burada else ifadesi bulunmamaktadır bu da zincirin son halkası olduğu anlamına gelir.
            }
        }
    }
}
