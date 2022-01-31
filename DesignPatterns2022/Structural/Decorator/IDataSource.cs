using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Structural.Decorator
{
    // Üst sınıfların uygulayacağı arayüzdür.
    // Yapılacak temel işlemler tanımlanmıştır.
    interface IDataSource
    {
        string GetFileName();
        void WriteData(Object data);
        void ReadData();
    }
}
