using System.Data.Entity;
using DotNet.Data.Context.EntityConfiguration;

namespace DotNet.Data.Context
{
    public class DotNetEfContext : DbContext
    {
        public DotNetEfContext() : base("DefaultConnection")
        {
            
        }

        public DbSet<SwaziKingWifeContext> SwaziKingsWives { get; set; }    

        public DbSet<SwaziKingContext> SwaziKings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new SwaziKingContextConfiguration());
            modelBuilder.Configurations.Add(new SwaziKingWifeContextConfiguration());   
            base.OnModelCreating(modelBuilder);
        }
    }
}
