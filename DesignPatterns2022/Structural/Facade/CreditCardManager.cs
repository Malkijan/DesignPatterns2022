using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Structural.Facade
{
    //Kredi kartı ile ilgili işlemlerin yapıldığı sınıf
    class CreditCardManager
    {
        public void CreateCreditCard(Customer customer)
        {
            // Parametre olarak gelen kullanıcıya ait kredi kartı oluşturma işleminin yapıldığı yer
            
            CreditCardManager creditCardManager = new CreditCardManager();
            BlackListService blackListService = new BlackListService();

            if (blackListService.CheckEmployeeIsTheBlackList(customer))
            {
                creditCardManager.CreateCreditCard(customer);
            }
        }
    }
}
