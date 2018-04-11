using System;
using System.Collections.Generic;
using System.Linq;
using posConsole;

namespace posConsole
{
    public class ProductItem
    {
        public List<string> allProduct = new List<string> { "Cement @ 750.00/= ---> Select 1", "Tank @ 40,000.00/= ---> Select 2", "Fiber Glass @ 1,400.00/= ---> Select 3", "Doors & Windows @ 500.00/= ---> Select 4", "Iron Sheets @ 1000.00/= ---> Select 5" };

        public List<string> GetList()
        {
            return allProduct;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            //products Price'
            int productName;
            string productQuantity;
            double productPrice;
            double productAmount;
            double productPoints;

            //every point is 200/=
            ProductItem myProducts = new ProductItem();
            List<string> productView = myProducts.GetList();

            int[] productNo = new int[5] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Select Product from Product List:");
            foreach (var item in productView)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("");
            
            Console.WriteLine("Enter Product No:");
            productName = Convert.ToInt32(Console.ReadLine());

            if (productNo.Contains(productName) == false)
            {
                Console.WriteLine("You entered an invalid Product No");
                Console.WriteLine("Enter Product No:");
                productName = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter Quantity:");
            productQuantity = Convert.ToString(Console.ReadLine());

            double prodQuantityDouble;
            if (double.TryParse(productQuantity, out prodQuantityDouble) == false)
            {
                Console.WriteLine("You entered an invalid Quantity");
                Console.WriteLine("Enter Quantity:");
                prodQuantityDouble = Convert.ToDouble(Console.ReadLine());
            }

            productPrice = ProductPrice.ProdPrice(productName);
            productAmount = AmountCalculate.AmountCalc(productPrice, prodQuantityDouble);
            productPoints = PointCalculation.PointsCalc(productAmount);

            Console.WriteLine("Total Amount:" + productAmount);
            Console.WriteLine("Total Points:" + productPoints);
            Console.ReadLine();
           
        }
    }
}
