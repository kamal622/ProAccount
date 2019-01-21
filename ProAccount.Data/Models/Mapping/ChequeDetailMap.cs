using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ProAccount.Data.Models.Mapping
{
    public class ChequeDetailMap : EntityTypeConfiguration<ChequeDetail>
    {
        public ChequeDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ChequeNo)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.IFSCCode)
                .HasMaxLength(100);

            this.Property(t => t.BankName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.BranchName)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("ChequeDetails");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.TransactionId).HasColumnName("TransactionId");
            this.Property(t => t.ChequeDate).HasColumnName("ChequeDate");
            this.Property(t => t.ChequeNo).HasColumnName("ChequeNo");
            this.Property(t => t.IFSCCode).HasColumnName("IFSCCode");
            this.Property(t => t.BankName).HasColumnName("BankName");
            this.Property(t => t.BranchName).HasColumnName("BranchName");

            // Relationships
            this.HasRequired(t => t.AccountTransaction)
                .WithMany(t => t.ChequeDetails)
                .HasForeignKey(d => d.TransactionId);

        }
    }
}
