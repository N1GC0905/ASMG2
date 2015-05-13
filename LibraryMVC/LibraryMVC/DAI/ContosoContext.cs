using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContosoUniversity.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace LibraryMVC.DAI
{
    public class ContosoContext : DbContext
    {
        public ContosoContext() : base("ContosoContext")
        {
        }
        
        public DbSet<LibraryMVC.Models.BangSach> BacngSachs { get; set; }
        public DbSet<LibraryMVC.Models.BangTG> BangTGs { get; set; }
        public DbSet<LibraryMVC.Models.BangNXB> BangNXBs { get; set; }
        public DbSet<LibraryMVC.Models.BangLoaiSach> TheLoai { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}