using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Behavioral.Strategy
{
    public class PaypalPayment : IPayment
    {
        private string _email;
        private string _password;

        public PaypalPayment(string email, string password)
        {
            _email = email;
            _password = password;
        }
        public void Pay(int amount)
        {
            //Paypal ile ödeme işlemlerinin gerçekleştiği yer.
            Console.WriteLine("Paid by Paypal");
        }
    }
}
