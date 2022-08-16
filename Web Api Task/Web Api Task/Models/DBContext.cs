using Microsoft.EntityFrameworkCore;
namespace Web_Api_Task.Models
{
    public class DBContext : DbContext
    {
        public virtual DbSet<Product>? product { get; set; }
        public virtual DbSet<Category>? Category { get; set; }

        public DBContext(){}
        public DBContext(DbContextOptions options):base(options){}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=WepApiMonofiaDotNetQ3;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
