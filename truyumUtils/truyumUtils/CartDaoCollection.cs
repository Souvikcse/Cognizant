using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace truyumUtils
{
    public class CartDaoCollection : ICartDao
    {
        public void AddCartItem(int userId, int itemId)
        {
            CartDaoSql DAO = new CartDaoSql();
            DAO.AddCartItem(userId, itemId);
        }

        public List<MenuItem> GetAllCartItems(int userId)
        {
            CartDaoSql DAO = new CartDaoSql();
            List<MenuItem> cartItems = DAO.GetAllCartItems(userId);
            if (cartItems.Count == 0)
            {
                return null;
            }
            else
                return cartItems;
        }

        public void RemoveCartItem(int userId, int productId)
        {
            throw new NotImplementedException();
        }
    }
}
