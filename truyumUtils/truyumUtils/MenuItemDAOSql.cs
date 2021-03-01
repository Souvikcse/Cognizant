using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace truyumUtils
{
    public class MenuItemDAOSql : IMenuItemDao
    {
        public string ConnectionString
        {
            get
            {
                return "Data Source=DESKTOP-E2B9EK8;Initial Catalog=truYumDB;Integrated Security=True";
            }
        }
        public List<MenuItem> GetMenuItemListAdmin()
        {
            List<MenuItem> items = new List<MenuItem>();
            MenuItem ob;
            try
            {
                using (var conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    var cmd = new SqlCommand("select * from Menu_items", conn);
                    var rd = cmd.ExecuteReader();
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
                        items.Add(ob);
                    }
                    conn.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return items;
        }
        public List<MenuItem> GetMenuItemListCustomer()
        {
            List<MenuItem> items = new List<MenuItem>();
            MenuItem ob;
            try
            {
                using (var conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    var cmd = new SqlCommand("select * from Menu_items where year(date_of_launch) >= 2016 ", conn);
                    var rd = cmd.ExecuteReader();
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
                        items.Add(ob);
                    }
                    conn.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return items;
        }

        public bool ModifyMenuItem(MenuItem menuitem)
        {
            bool result = false;
            try
            {
                using (var conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    var cmd = new SqlCommand($"update Menu_items " +
                                             $"set item_name = '{menuitem.Name}'," +
                                                $"price = {menuitem.Price}," +
                                                $"category = '{menuitem.Category}'," +
                                                $"free_delivery = {(menuitem.FreeDel? 1:0)}" +
                                                $"where item_id = {menuitem.Id} ", conn);
                    var rd = cmd.ExecuteNonQuery();
                    if (rd > 0)
                        result = true;

                    conn.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return result;
        }
        public MenuItem GetMenuItem(int id)
        {
            MenuItem ob = null;
            try
            {
                using (var conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    var cmd = new SqlCommand($"select * from Menu_items where item_id = {id} ", conn);
                    var rd = cmd.ExecuteReader();
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
                    }
                    conn.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return ob;
        }
    }
}
