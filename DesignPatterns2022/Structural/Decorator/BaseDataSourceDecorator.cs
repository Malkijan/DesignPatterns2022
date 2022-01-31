using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Structural.Decorator
{
    // Constructor sayesinde özellikleri değiştirilmesi istenen nesnenin referansı tutulur.
    // Bu sınıftan türeyen sınıfların uygulamasını, değiştirilmesini istediğimiz metotları abstract anahtar kelimesi ile işaretledik.
    abstract class BaseDataSourceDecorator : IDataSource
    {
        protected IDataSource dataSource;

        public BaseDataSourceDecorator(IDataSource dataSource)
        {
            this.dataSource = dataSource;
        }
        public abstract string GetFileName();

        public abstract void ReadData();

        public abstract void WriteData(object data);
    }
}
