using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // SKU = Stock Keeping Unit
            string sku = "01-MN-L";

            string[] product = sku.Split('-');

            string type = "";
            string color = "";
            string size = "";
            int number = int.Parse(product[0]);
            switch (number)
            {
                case 1:
                    type = "Sweat shirt";
                    break;

                case 2:
                    type = "T-Shirt";
                    break;

                case 3:
                    type = "sWEET PANTS";
                    break;
                default:
                    type = "other";
                    break;
            }

            switch (product[2])
            {
                case "MN":
                    color = "black";
                    break;

                case "BL":
                    color = "Maroon";
                    break;

                default:
                    color = "White";
                    break;
            }
            switch (product[2])
            {
                case "S":
                    size = "small";
                    break;

                case "M":
                    size = "Medium";
                    break;

                default:
                    size = "Large";
                    break;
            }
            Console.WriteLine($"Product: {size} {color} {type}");
        }
    }
}
