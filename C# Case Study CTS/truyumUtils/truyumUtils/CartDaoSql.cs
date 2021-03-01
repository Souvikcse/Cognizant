using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace truyumUtils
{
    public class CartDaoSql : ICartDao
    {
        public string ConnectionString
        {
            get
            {
                return "Data Source=DESKTOP-E2B9EK8;Initial Catalog=truYumDB;Integrated Security=True";
            }
        }
        public void AddCartItem(int userId, int itemId)
        {
            try
            {
                using (var conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    var cmd = new SqlCommand($"insert into Cart_invoice(cart_id, item_id) values ((select Cart_id from Cart where users_id = {userId}), {itemId});", conn);
                    var rd = cmd.ExecuteNonQuery();
                    if (rd > 0)
                    {
                        Console.WriteLine("Added to Cart successfully");
                    }
                    else
                    {
                        Console.WriteLine("Could not be added to cart!!!");
                    }
                    conn.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public List<MenuItem> GetAllCartItems(int userId)
        {
            List<MenuItem> cartItems = new List<MenuItem>();
            MenuItem ob = null;
            try
            {
                using (var conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    var cmd = new SqlCommand($"select * from Menu_items m join Cart_invoice c on m.item_id = c.item_id and c.cart_id in (select Cart_id from Cart where users_id = {userId});", conn);
                    var rd = cmd.ExecuteReader();
                    if (!rd.HasRows)
                    {
                        throw new CartEmptyException("Your Cart is Empty!!");
                    }
                    while (rd.Read())
                    {
                        ob = new MenuItem()
                        {
                            Id = (int)rd[0],
                            Name = (string)rd[1],
                            Price = Convert.ToInt32(rd[2]),
                            LaunchDate = Convert.ToString(rd[3]),
                            Category = (string)rd[4],
                            FreeDel = Convert.ToBoolean(rd[5])
                        };
                        cartItems.Add(ob);
                    }
                    conn.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return cartItems;
        }

        public void RemoveCartItem(int userId, int productId)
        {
            throw new NotImplementedException();
        }
    }
}
