using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace quanlydoanvien_1.Areas.Admin.Models
{
    public class Loginmodel
    {
        [Required]
        public string Username { set; get; }
        public string Password { set; get; }
    }
}