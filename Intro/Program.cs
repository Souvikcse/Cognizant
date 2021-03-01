using System;
using System.Collections.Generic;
using static System.Console;
using truyumUtility;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("-------Printing Admin Menu Item List---------------");
            MenuItemCollectionBO BO = new MenuItemCollectionBO();
            List<MenuItem> adminList = BO.GetMenuItemListAdmin();
            foreach (var item in adminList){
                WriteLine($"{item.Id}, {item.Name}, {item.Price}, {item.LaunchDate}");
            }
            WriteLine("\n-------Printing Customer Menu Item List---------------");
            List<MenuItem> customerList = BO.GetMenuItemListCustomer();
            foreach (var item in customerList){
                WriteLine($"{item.Id}, {item.Name}, {item.Price}, {item.LaunchDate}");
            }
        }
    }
}
