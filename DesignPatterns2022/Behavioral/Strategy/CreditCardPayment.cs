using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Behavioral.Strategy
{
    class CreditCardPayment : IPayment
    {
        private string _name;
        private string _cardNumber;
        private string _cvv;
        private string _dateOfExpire;

        public CreditCardPayment(string name, string ccNum,string cvv, string expiryDate)
        {
            _name = name;
            _cardNumber = ccNum;    
            _cvv = cvv; 
            _dateOfExpire = expiryDate;
        }
        public void Pay(int amount)
        {
            // Kredi kartı ödeme işlemlerinin gerçekleştiği yer.
            Console.WriteLine("Paid by Credit cart.");

        }
    }
}
