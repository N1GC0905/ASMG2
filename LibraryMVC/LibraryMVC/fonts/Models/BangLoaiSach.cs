using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryMVC.Models
{
    public class BangLoaiSach
    {
        public int MaLoai { get; set; }
        public string TenLoai { get; set; }
        public virtual ICollection<BangLoaiSach> TheLoai { get; set; }
    }
}