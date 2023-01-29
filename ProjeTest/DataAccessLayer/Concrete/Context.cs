using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-THP3847\\SQLEXPRESS;database=DbProjeTestt; integrated security=true;Encrypt=false");
        }
        public DbSet<KayitSistemi> kayitSistemis { get; set; }
        public DbSet<UyeCv> uyeCvs { get; set; }
        public DbSet<UyeSorülar> uyeSorülars { get; set; }
        public DbSet<AdminPanel> adminPanels { get; set; }
    }
}
