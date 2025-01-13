using Electronice.dispozitive.Model;
using Microsoft.EntityFrameworkCore;


namespace Electronice.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {



        }
        public virtual DbSet<Electronic> Electronics
        {

            get;
            set;

        }

    }
}
