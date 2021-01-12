using Market_otomasyon.Moduls.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_otomasyon.Context
{
    public class MarketDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=LAPTOP-9RQDBGSD\SQLEXPRESS;database=MarketProje;trusted_connection=true;");
        }
        public DbSet<Borc> Borcs { get; set; }
        public DbSet<Musteri> Musteris { get; set; }
        public DbSet<Satici> Satıcıs { get; set; }
    }
}
