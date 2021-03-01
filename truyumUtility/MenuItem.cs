using System;

namespace truyumUtility
{
    public class MenuItem
    {
        public MenuItem() {}
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string LaunchDate { get; set; }
        public string Category { get; set; }
        public bool FreeDel { get; set; }
    }
}
