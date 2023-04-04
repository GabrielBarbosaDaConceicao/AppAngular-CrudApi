using Microsoft.EntityFrameworkCore;

namespace CRUDAPI.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-PM25KSV\\SQLEXPRESS; Initial Catalog=AngWebAPIBD; Integrated Security=True; TrustServerCertificate=True;");
        }
    }
}