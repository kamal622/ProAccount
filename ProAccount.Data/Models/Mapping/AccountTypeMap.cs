using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ProAccount.Data.Models.Mapping
{
    public class AccountTypeMap : EntityTypeConfiguration<AccountType>
    {
        public AccountTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("AccountType");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Type).HasColumnName("Type");
        }
    }
}
