using HavaalaniOtomasyonuApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HavaalaniOtomasyonuApp.DAL
{
    public class HavaalaniContext : DbContext 
    {

        public HavaalaniContext() : base("cstr")
        {
            
        }
       
        public DbSet<Havaalani> Havaalanlari { get; set; } // veritabanındaki belleklerin karşılığı
        public DbSet<Ucak> Ucaklar { get; set; }
        public DbSet<Admin> Adminler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Havaalani>().ToTable("tblHavaalanlari");
            modelBuilder.Entity<Havaalani>().Property(h => h.Havaalani_Adi).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Havaalani>().Property(h => h.Havaalani_Kodu).HasColumnType("varchar").HasMaxLength(75).IsRequired();

            modelBuilder.Entity<Ucak>().ToTable("tblUcaklar");
            modelBuilder.Entity<Ucak>().Property(u => u.Ucak_Adi).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Ucak>().Property(u => u.Kapasite).HasColumnType("int").IsRequired();

            modelBuilder.Entity<Admin>().ToTable("tblAdminler");
            modelBuilder.Entity<Admin>().Property(u => u.username).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Admin>().Property(u => u.password).HasColumnType("varchar").HasMaxLength(50).IsRequired();

        }
    }
}
