using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class PayingToCompany
    {

        private readonly IPaymentMethodcs _paymentMethods;

        public PayingToCompany(IPaymentMethodcs paymentMethodcs)
        {
            _paymentMethods = paymentMethodcs;
        }
        public void Pay(decimal Amount)
        {
            _paymentMethods.PayMoney(Amount);
        }
    }
}
