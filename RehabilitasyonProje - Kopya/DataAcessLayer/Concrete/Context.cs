using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.Concrete
{
    //veri tabanı tabloları ve sql stringini tutar 
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=104.247.161.58//MSSQLSERVER2022 ;database=SarikamisDb;user=admindb;password=Berivan.36");
        }

        public DbSet<Hakkinda> THakkinda { get; set;}
        public DbSet<Hizmetler> THizmetler { get; set;}
        public DbSet<İletisim> Tİletisim { get; set;}
        public DbSet<Ogrenci> TOgrenci { get; set;}
        public DbSet<Personel> TPersonel { get; set;}
        public DbSet<Portfolio> TPortfolio { get; set;}
      

    }
}
