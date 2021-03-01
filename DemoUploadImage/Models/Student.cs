using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DemoUploadImage.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public int Sid { get; set; }
        public string sname { get; set; }
        public string sphoto { get; set; }
        public string city { get; set; }
    }
}