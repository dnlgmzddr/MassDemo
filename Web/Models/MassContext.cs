using System.Data.Entity;

namespace WebApplication1.Models
{
    class MassContext : DbContext 
    {
        public MassContext():base("MassEntities")
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}