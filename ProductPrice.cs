using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posConsole
{
    public static class ProductPrice
    {
        public static double ProdPrice(double pointproductNo)
        {
            double price = 0;
            switch (pointproductNo)
            {
                case 1:
                    price = 750;
                    break;

                case 2:
                    price = 40000;
                    break;

                case 3:
                    price = 1400;
                    break;

                case 4:
                    price = 500;
                    break;

                case 5:
                    price = 1000;
                    break;
            }

            return price;
        }
    }
}
