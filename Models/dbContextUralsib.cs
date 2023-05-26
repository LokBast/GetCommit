using Microsoft.EntityFrameworkCore;

namespace URALSIB.Models
{
    public class dbContextUralsib
    {
        public class YourDbContext : DbContext
        {
            public DbSet<Commit> Commits { get; set; } // Пример свойства DbSet

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Uralsib;Data Source=DESKTOP-3E6ME6N;"); // Замените "YourConnectionString" на вашу строку подключения
            }
        }
    }
}
