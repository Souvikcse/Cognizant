using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace truyumUtils
{
    interface IMenuItemDao
    {
        List<MenuItem> GetMenuItemListAdmin();
        List<MenuItem> GetMenuItemListCustomer();
        bool ModifyMenuItem(MenuItem menuItem);
        MenuItem GetMenuItem(int id);
    }
}
