using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posConsole
{
    public class productItem
    {
        public int ProductId = 5;
        public List<string> allProduct = new List<string> { "Cement @ 750.00/= Select 1", "Tank @ 40,000.00/= Select 2", "Fiber Glass @ 1,400.00/= Select 3", "Doors & Windows @ 500.00/= Select 4", "Iron Sheets @ 1000.00/= Select 5" };

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
            double cementPrice = 750.00;
            double tankPrice = 40000.00;
            double fiberGlassPrice = 1400.00;
            double doorsWindowsPrice = 500.00;
            double ironSheetsPrice = 1000.00;

            int productName;
            string productQuantity;
            double resultPoints = 0;
            double resultAmount = 0;

            //every point is 200/=
            int points = 200;
            double cementPoints = cementPrice / points;
            double tankPoints = tankPrice / points;
            double fiberGlassPoints = fiberGlassPrice / points;
            double doorsWindowsPoints = doorsWindowsPrice / points;
            double ironSheetsPoints = ironSheetsPrice / points;

            productItem myProducts = new productItem();
            List<string> productView = myProducts.GetList();

            int[] productNo = new int[5] { 1, 2, 3, 4, 5 };
            int[] marks = new int[5] ;

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

            switch (productName)
            {
                case 1:
                    resultAmount = prodQuantityDouble * cementPrice;
                    resultPoints = prodQuantityDouble * cementPoints;
                    break;

                case 2:
                    resultAmount = prodQuantityDouble * tankPrice;
                    resultPoints = prodQuantityDouble * tankPoints;
                    break;

                case 3:
                    resultAmount = prodQuantityDouble * fiberGlassPrice;
                    resultPoints = prodQuantityDouble * fiberGlassPoints;
                    break;

                case 4:
                    resultAmount = prodQuantityDouble * doorsWindowsPrice;
                    resultPoints = prodQuantityDouble * doorsWindowsPoints;
                    break;

                case 5:
                    resultAmount = prodQuantityDouble * ironSheetsPrice;
                    resultPoints = prodQuantityDouble * ironSheetsPoints;
                    break;
            }
            Console.WriteLine("Total Amount:" + resultAmount);
            Console.WriteLine("Points Earned:" + resultPoints);
            Console.ReadLine();
        }
    }
}
