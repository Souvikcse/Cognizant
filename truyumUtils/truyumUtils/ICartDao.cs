using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace truyumUtils
{
    interface ICartDao
    {
        void AddCartItem(int userId, int itemId);
        List<MenuItem> GetAllCartItems(int userId);
        void RemoveCartItem(int userId, int productId);
    }
}
