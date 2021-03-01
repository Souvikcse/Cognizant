using System;
using System.Collections.Generic;

namespace truyumUtility
{
    public class MenuItemCollectionBO
    {
        public MenuItemCollectionBO() {}
        public List<MenuItem> GetMenuItemListAdmin(){
            MenuItemsDAO DAO = new MenuItemsDAO();
            List<MenuItem> items = DAO.GetMenuItemListAdmin();
            return items; 
        }
        public List<MenuItem> GetMenuItemListCustomer(){
            MenuItemsDAO DAO = new MenuItemsDAO();
            List<MenuItem> items = DAO.GetMenuItemListCustomer();
            return items; 
        }
    }
}