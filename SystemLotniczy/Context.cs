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
        public DbSet<Lot> Loty { get; set; }     
        //Tutajkonfiguracja tabeli, w metodzie tej można teżnp.określać relacje między tabelami
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lot>().HasKey(x => x.id_lotu);
        }
    }
}
