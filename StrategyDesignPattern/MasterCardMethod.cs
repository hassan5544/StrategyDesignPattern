using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class MasterCardMethod : IPaymentMethodcs
    {
        public void PayMoney(decimal Amount)
        {
            Console.WriteLine("Master Card " + Amount);
        }
    }
}
