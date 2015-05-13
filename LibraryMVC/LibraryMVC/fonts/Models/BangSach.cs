using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryMVC.Models
{
    public class BangSach
    {
        public int MaSach { get; set; }
        public int MaLoai { get; set; }
        public string TenSach { get; set; }
        public string TomTat { get; set; }
        public int MaTG { get; set; }
        public int MaNXB { get; set; }
        public virtual ICollection<BangSach> BangSachs { get; set; }
    }
}