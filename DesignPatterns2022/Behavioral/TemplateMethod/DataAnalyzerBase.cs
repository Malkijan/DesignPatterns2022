using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Behavioral.TemplateMethod
{
    // Metot iskeletimizi ve soyutlanmış metotları içermektedir.
    abstract class DataAnalyzerBase
    {
        public void AnalyzeDataOfLastWeek()
        {
            object data = GetDataOfTheLastWeek();
            object result = AnalyzeData(data);
            ExportResult(result);
        }

        private object AnalyzeData(object data)
        {
            // Burada verinin analizi süreci yer almaktadır.
            // Analiz sonuçları default olarak bir obje dönmektedir.
            Console.WriteLine("Method Worked: AnalyzedData");
            return new object();
        }

        private object GetDataOfTheLastWeek()
        {
            // Burada veri verinin çağrılma süreçleri yer alacaktır.
            // Default olarak bir obje dönülmektedir.
            Console.WriteLine("Method worked: GetDataOfTheLastWeek");
            return new object();
        }

        // Alt sınıflar tarafından uygulanmasını istediğimiz metottur.
        // Metot iskeleti içerisinde farklılık gösterecek olan metotumuzdur.
        public abstract void ExportResult(object data);
    }
}
