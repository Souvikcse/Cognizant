using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCBasics.Models
{
    [Table("Cart")]
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual ICollection<MenuItem> ItemList { get; set; }
    }
}