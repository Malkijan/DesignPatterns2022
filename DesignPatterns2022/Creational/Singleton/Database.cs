using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Creational.Singleton
{
    //Detaylı bilgi için: https://hakantopuz.medium.com/singleton-design-pattern-nedir-nas%C4%B1l-%C3%A7al%C4%B1%C5%9F%C4%B1r-nas%C4%B1l-kullan%C4%B1l%C4%B1r-be655b13978c
    public class Database
    {
        private static object _lockObject = new object();
        /// <summary>
        /// Static bir değişken olmalıdır, referansı tutmak için.
        /// Multi-thread yapılarda daha da güvenli olması açısından volatile olarak oluştururuz.
        /// </summary>
        private static volatile Database database;

        /// <summary>
        /// Constructor (oluşturucu metotu) private olmalıdır. Bunun amacı nesne oluşumunu tek yerden sağlamak. İstemcinin, new anahtar kelimesini kullanması engellemektir.
        /// </summary>
        private Database()
        {

        }

        /// <summary>
        /// Tutulan referansa erişmek için bir metot olmalıdır, getInstance()
        /// </summary>
        /// <returns></returns>
        public static Database GetInstance()
        {
            if (database == null)
            {
                lock (_lockObject)
                {
                    if (database == null)
                    {
                        database = new Database();
                    }
                }
            }
            return database;
        }
    }
}
