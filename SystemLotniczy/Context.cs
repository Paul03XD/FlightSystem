using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLotniczy
{
    public class ApplicationDbContext : DbContext
    {    
        //konstruktor przekazuje opcje połączenia do konstruktora bazowego
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        //Model tabeli (odpowiada danejtabeli w bazie)
        public DbSet<Klient> Klienci { get; set; }
        public DbSet<Samolot> Samoloty { get; set; }
        public DbSet<Lot> Loty { get; set; }
        public DbSet<Lotnisko> Lotniska { get; set; }
        public DbSet<Rezerwacja> Rezerwacje { get; set; }
        public DbSet<Trasa> Trasy { get; set; }
        public DbSet<Firma> Firmy { get; set; }

        //Tutajkonfiguracja tabeli, w metodzie tej można teżnp.określać relacje między tabelami
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Klient>().HasKey(x => x.id);
            modelBuilder.Entity<Samolot>().HasKey(x => x.id);
            modelBuilder.Entity<Lotnisko>().HasKey(x => x.id);
            modelBuilder.Entity<Lot>().HasKey(x => x.id);
            modelBuilder.Entity<Rezerwacja>().HasKey(x => x.id);
            modelBuilder.Entity<Trasa>().HasKey(x => x.id);
            modelBuilder.Entity<Firma>().HasKey(x => x.id);
        }
    }
}
