using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using truyumUtils;

namespace UITruyum
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;
            Console.WriteLine("---------Welcome to truyum---------");
            while (!quit)
            {
                Console.WriteLine("Enter 1 for Admin, 2 for Customer");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Press 1 for Viewing items, 2 for Modifying items");
                    int ch = int.Parse(Console.ReadLine());
                    if (ch == 1)
                    {
                        MenuItemDaoCollection BO = new MenuItemDaoCollection();
                        List<MenuItem> items = BO.GetMenuItemListAdmin();
                        Console.WriteLine("Id.  Name \t Price \t Launch Date \t Category \t Free Delivery");
                        foreach (MenuItem item in items)
                        {
                            Console.WriteLine(item.ToString());
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter Item id to modify");
                        int id = int.Parse(Console.ReadLine());
                        MenuItemDaoCollection BO = new MenuItemDaoCollection();
                        MenuItem item = BO.GetMenuItem(id);

                        Console.WriteLine("Existing Info: " + item.ToString());
                        Console.WriteLine("Enter Name");
                        string name = Console.ReadLine();

                        Console.WriteLine("Enter price");
                        float price = float.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Category");
                        string category = Console.ReadLine();

                        Console.WriteLine("Free Delivery Available? (Y/n)");
                        bool freedel = Console.ReadLine()[0] == 'Y' ? true : false;

                        item.Name = name;
                        item.Price = price;
                        item.Category = category;
                        item.FreeDel = freedel;

                        bool res = BO.ModifyMenuItem(item);
                        if (res)
                        {
                            Console.WriteLine("Item Updated successfully!!");
                        }
                        else
                        {
                            Console.WriteLine("Update Failed!!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Active Items");
                    MenuItemDaoCollection BO = new MenuItemDaoCollection();
                    CartDaoCollection CartBO = new CartDaoCollection();
                    List<MenuItem> items = BO.GetMenuItemListCustomer();

                    Console.WriteLine("Id  Name \t Price \t Launch Date \t Category \t Free Delivery");
                    int i;
                    foreach (MenuItem item in items)
                    {
                        Console.WriteLine(item.ToString());
                    }
                    while (true)
                    {
                        Console.WriteLine("Do you want to add to cart? Y/n");
                        string ch = Console.ReadLine();
                        if (ch[0] == 'n') break;

                        Console.WriteLine("Enter item id to add to cart");
                        int itemId = int.Parse(Console.ReadLine());
                        CartBO.AddCartItem(1, itemId);
                    }
                    Console.WriteLine("Items in your Cart------------");
                    Console.WriteLine("Id  Name \t Price \t Free Delivery");
                    List<MenuItem> cartItems = CartBO.GetAllCartItems(1);
                    i = 0;
                    if (cartItems != null)
                    {
                        foreach (var item in cartItems)
                        {
                            i++;
                            Console.WriteLine($"{i}. {item.Name} \t {item.Price} \t {(item.FreeDel ? "Yes" : "No")}");
                        }
                    }
                }
                Console.WriteLine("Do you want to quit?(Y/n)");
                string ans = Console.ReadLine();
                if (ans[0] == 'Y')
                {
                    quit = true;
                }
            }
            Console.ReadKey();
        }
    }
}
