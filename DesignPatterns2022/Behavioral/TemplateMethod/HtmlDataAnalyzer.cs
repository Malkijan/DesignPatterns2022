using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Behavioral.TemplateMethod
{
    class HtmlDataAnalyzer : DataAnalyzerBase
    {
        public override void ExportResult(object result)
        {
            // Durumun HTML'e dönüştürülmesi işlemleri yer alacaktır.
            Console.WriteLine("HTML exported");
        }
    }
}
