using System.Data.Entity.ModelConfiguration;

namespace DotNet.Data.Context.EntityConfiguration
{
    public class SwaziKingContextConfiguration : EntityTypeConfiguration<SwaziKingContext>
    {
        public SwaziKingContextConfiguration()
        {
            ToTable("SwaziKing");
            HasKey(k => k.Id);
            Property(p => p.Name).IsRequired().HasMaxLength(50);
            Property(p => p.KnownAs).IsOptional().HasMaxLength(100);
            Property(p => p.DateOfBirth).IsRequired();
            Property(a => a.Guid).HasMaxLength(32).IsRequired();
            Property(a => a.DateCreated).IsRequired();
            Property(a => a.DateModified).IsOptional();
            Ignore(a => a.ObjectState);
            Property(a => a.RowVersion).IsRowVersion();

            
        }
    }
}
