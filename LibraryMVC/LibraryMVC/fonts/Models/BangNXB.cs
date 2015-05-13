using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryMVC.Models
{
    public class BangNXB
    {
        public int MaNXB { get; set; }
        public string TenNXB { get; set; }
        public string DiaChi { get; set; }
        public int SDT { get; set; }
        public string Email { get; set; }
        public virtual ICollection<BangNXB> ListSach { get; set; }
    }
}