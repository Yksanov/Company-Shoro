using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subd_1laba.Models1
{
    public class ShoroDBContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-BPVVGFF\\SQLEXPRESS;Initial Catalog=laba6;Integrated Security=True;");
        }

        public DbSet<Employes> Employees { get; set; }
        public DbSet<Material> Material { get; set; }
        public DbSet<Purchase> Purchase { get; set; }
        public DbSet<Production> Production { get; set; }
        public DbSet<Release> Release { get; set; }
        public DbSet<Ingredients> Ingredients { get; set; }
        public DbSet<Measures> Measures { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Budget> Budget { get; set; }
        public DbSet<Selling> Selling { get; set; }
    }
}
