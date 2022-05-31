using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciMvcOdev.Models
{
    public class OgrencilerContext:DbContext
    {
        public DbSet<Ogrenciler> tblOgrenciler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS; Initial Catalog=Ogrencidb; Integrated Security=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ogrenciler>().ToTable("tblOgrenciler");
            modelBuilder.Entity<Ogrenciler>().Property(p => p.Ad).HasColumnType("varchar").HasMaxLength(20).IsRequired();

            modelBuilder.Entity<Ogrenciler>().Property(p => p.Soyad).HasColumnType("varchar").HasMaxLength(20).IsRequired();

        }
    }
}
