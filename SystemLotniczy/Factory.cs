using CsvHelper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLotniczy
{
    public class ApplicationDbContextFactory:IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args= null)
        { 
            var options = new DbContextOptionsBuilder<ApplicationDbContext>();
            options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=FlightSystemDatabase;Trusted_Connection=True;TrustServerCertificate=True;"); 
            // TrustServerCertificate=> akceptujemy to połączenie
            return new ApplicationDbContext(options.Options);
        }
    }
}
