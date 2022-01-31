using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Structural.Decorator
{
    // Yeni davranışların tanımlandığı sınıftır.
    class ComporessionDecorator : BaseDataSourceDecorator
    {
        public ComporessionDecorator(IDataSource dataSource) : base(dataSource)
        {
        }

        public override string GetFileName()
        {
            return base.dataSource.GetFileName();
        }

        public override void ReadData()
        {
            // Veriyi okurken referansını tuttuğumuz sınıfın kendi davranışını sergilemesini istiyoruz.
            base.dataSource.ReadData();
        }

        public override void WriteData(object data)
        {
            // Burada gelen veriye ait sıkıştırma işlemleri yapılacaktır.
            Console.WriteLine("Data compressed.");

            // Sıkıştırma işlemleri yapıldıktan sonra yazma işlemleri gerçekleştirilecektir.
            Console.WriteLine($"Compressed data was written to {base.dataSource.GetFileName()}.");
        }
    }
}
