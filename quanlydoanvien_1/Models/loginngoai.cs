using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace quanlydoanvien_1.Models
{
    
    public class loginngoai
    {
        [Key]
        public string Username { set; get; }
        public string Password { set; get; }
    }
}