using Microsoft.EntityFrameworkCore;

namespace AppSzerviz.Models
{
    public class Context:DbContext
    {
        string c = "Server=localhost;Database=szervizdb;Uid=root;Pwd=;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(c, ServerVersion.AutoDetect(c));
        }
        public DbSet<Bejelentes> Bejelentesek { get; set; }
    }
}
