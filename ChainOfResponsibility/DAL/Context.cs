using Microsoft.EntityFrameworkCore;

namespace ChainOfResponsibility.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=EGD\\SQLEXPRESS;Initial Catalog=ChainOfDb;integrated security=true");
        }
        public DbSet<CustomerProcess> CustomerProcess { get; set; }
    }
}
