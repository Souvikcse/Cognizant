using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace truyumUtility
{
    public class MenuItemsDAO
    {
        public string ConnectionString{
            get  {
                return "";
            }
        }
        public List<MenuItem> GetMenuItemListAdmin()
        {
            List<MenuItem> items = new List<MenuItem>();
            MenuItem ob;
            try{
                using(var conn = new SqlConnection(ConnectionString)){
                    conn.Open();
                    var cmd = new SqlCommand("select * from Menu_items", conn);
                    var rd = cmd.ExecuteReader();
                    while(rd.Read()){
                        ob = new MenuItem() {
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
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
            return items;
        }
        public List<MenuItem> GetMenuItemListCustomer(){
            List<MenuItem> items = new List<MenuItem>();
            MenuItem ob;
            try{
                using(var conn = new SqlConnection(ConnectionString)){
                    conn.Open();
                    var cmd = new SqlCommand("select * from Menu_items where year(date_of_launch) >= 2016 ", conn);
                    var rd = cmd.ExecuteReader();
                    while(rd.Read()){
                        ob = new MenuItem() {
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
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
            return items;
        }

    }
}