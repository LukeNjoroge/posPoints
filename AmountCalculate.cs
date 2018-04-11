using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posConsole
{
    class AmountCalculate
    {
       
        public double AmountCalc(double productPrice, double productQuantity)
        {
            
            double resultAmount = productPrice * productQuantity;
            return resultAmount;
        }
    }
}
