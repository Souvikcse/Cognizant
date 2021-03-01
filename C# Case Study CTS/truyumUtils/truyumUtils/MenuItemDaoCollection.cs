using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace truyumUtils
{
    public class MenuItemDaoCollection : IMenuItemDao
    {
        public MenuItemDaoCollection() { }

        public List<MenuItem> GetMenuItemListAdmin()
        {
            MenuItemDAOSql DAO = new MenuItemDAOSql();
            List<MenuItem> items = DAO.GetMenuItemListAdmin();
            return items;
        }
        public List<MenuItem> GetMenuItemListCustomer()
        {
            MenuItemDAOSql DAO = new MenuItemDAOSql();
            List<MenuItem> items = DAO.GetMenuItemListCustomer();
            return items;
        }
        public bool ModifyMenuItem(MenuItem menuitem)
        {
            MenuItemDAOSql DAO = new MenuItemDAOSql();
            bool status = DAO.ModifyMenuItem(menuitem);

            return status;
        }
        public MenuItem GetMenuItem(int id)
        {
            MenuItemDAOSql DAO = new MenuItemDAOSql();
            MenuItem item = DAO.GetMenuItem(id);
            return item;
        }
    }
}
