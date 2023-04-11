
using User_Authorization_Authentication.Models;


namespace User_Authorization_Authentication.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder
                .UseSqlServer("Server=.\\jagbe;Database=userdb;Trusted_Connection=true;");
        }

        public DbSet<User> Users => Set<User>();
    }
}
