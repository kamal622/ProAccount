using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ProAccount.Data.Models.Mapping
{
    public class AccountMap : EntityTypeConfiguration<Account>
    {
        public AccountMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.AccountCode)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ContactName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ContactNo)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.Address)
                .HasMaxLength(500);

            this.Property(t => t.Email)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Account");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FirmId).HasColumnName("FirmId");
            this.Property(t => t.AccountTypes).HasColumnName("AccountTypes");
            this.Property(t => t.AccountCode).HasColumnName("AccountCode");
            this.Property(t => t.ContactName).HasColumnName("ContactName");
            this.Property(t => t.ContactNo).HasColumnName("ContactNo");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.OpeningDebit).HasColumnName("OpeningDebit");
            this.Property(t => t.OpeningCredit).HasColumnName("OpeningCredit");

            // Relationships
            this.HasRequired(t => t.AccountType)
                .WithMany(t => t.Accounts)
                .HasForeignKey(d => d.AccountTypes);
            this.HasRequired(t => t.Firm)
                .WithMany(t => t.Accounts)
                .HasForeignKey(d => d.FirmId);

        }
    }
}
