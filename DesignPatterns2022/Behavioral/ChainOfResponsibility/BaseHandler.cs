using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Behavioral.ChainOfResponsibility
{
    // Zincirin bir sonraki halkasının tanımlandığı sınıftır.
    // İşlemi gerçekleştirecek olan metot tanımı bulunur.
    abstract class BaseHandler
    {
        protected BaseHandler _nextHandler;

        public void SetNextHandler(BaseHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }
        public abstract void HandleRequest(Image image);
    }
}
