using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_handson_SRP_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our site. Would you like to order or repair?");
            string processOption = Console.ReadLine().ToLower().Trim();
            //PhoneOrderRepair phoneOrderRepair = new PhoneOrderRepair();
            string productDetail = string.Empty;

            switch (processOption)
            {
                case "order":
                    Console.WriteLine("Please provide the phone model name");
                    productDetail = Console.ReadLine().Trim();
                    PhoneOrder phOrder = new PhoneOrder();
                    phOrder.ProcessOrder(productDetail);
                    break;
                case "repair":
                    Console.WriteLine("Is it the phone or the accessory that you want to be repaired?");
                    string productType = Console.ReadLine().ToLower();
                    if (productType.Equals("phone"))
                    {
                        Console.WriteLine("Please provide the phone model name");
                        productDetail = Console.ReadLine().Trim();
                        //phoneOrderRepair.ProcessPhoneRepair(productDetail);
                        PhoneRepair phRepair = new PhoneRepair();
                        phRepair.ProcessPhoneRepair(productDetail);
                    }
                    else
                    {
                        Console.WriteLine("Please provide the accessory detail, like headphone, tempered glass");
                        productDetail = Console.ReadLine().Trim();
                        //phoneOrderRepair.ProcessAccessoryRepair(productDetail);
                        AccessoryRepair accRepair = new AccessoryRepair();
                        accRepair.ProcessAccessoryRepair(productDetail);
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine("Thanks for choosing us. Have a great day.");
        }
    }
}
