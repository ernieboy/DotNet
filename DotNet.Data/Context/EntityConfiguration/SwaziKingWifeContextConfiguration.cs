using System.Data.Entity.ModelConfiguration;

namespace DotNet.Data.Context.EntityConfiguration
{
    public class SwaziKingWifeContextConfiguration : EntityTypeConfiguration<SwaziKingWifeContext>
    {
        public SwaziKingWifeContextConfiguration()  
        {
            ToTable("SwaziKingWife");
            HasKey(k => k.Id);
            Property(p => p.Name).IsRequired().HasMaxLength(50);
            Property(p => p.KnownAs).IsOptional().HasMaxLength(100);
            Property(p => p.DateOfBirth).IsRequired();
            Property(a => a.Guid).HasMaxLength(32).IsRequired();
            Property(a => a.DateCreated).IsRequired();
            Property(a => a.DateModified).IsOptional();
            Ignore(a => a.ObjectState);
            Property(a => a.RowVersion).IsRowVersion();

          
            //See http://www.entityframeworktutorial.net/code-first/configure-one-to-many-relationship-in-code-first.aspx
            HasRequired(k => k.King).WithMany(w => w.Wives).HasForeignKey(fk => fk.KingId);
        }
    }
}
