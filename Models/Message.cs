using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestApp6.Models
{
    public class Message
    {
        [Key]
        public int PostID { get; set; }
        public string Posts { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}