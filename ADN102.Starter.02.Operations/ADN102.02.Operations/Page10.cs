using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page10
{
    public class Product
    {
        public double newPayments(double cost, double deliveryFee)
        {
            double cents = 0;

            // cents is currently initialized to 0
            // return the sum of the cost and deliveryFee variables in cents (multiply by 100)

            // cents = write an expression here
            cents = (cost + deliveryFee) * 100;
            
            return cents;
        }
    }
}
