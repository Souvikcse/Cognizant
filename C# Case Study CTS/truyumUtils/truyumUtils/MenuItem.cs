using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace truyumUtils
{
    public class MenuItem
    {
        public MenuItem() { }
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string LaunchDate { get; set; }
        public string Category { get; set; }
        public bool FreeDel { get; set; }

        public override string ToString()
        {
            return $"{Id}.  {Name} \t {Price} \t {LaunchDate} \t {Category} \t {(FreeDel?"Yes":"No")}";
        }
    }
}
