using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ProAccount.Data.Models.Mapping
{
    public class AccountTransactionMap : EntityTypeConfiguration<AccountTransaction>
    {
        public AccountTransactionMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.TransactionsType)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PaymentType)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("AccountTransactions");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.TransactionDate).HasColumnName("TransactionDate");
            this.Property(t => t.FirmId).HasColumnName("FirmId");
            this.Property(t => t.AccountId).HasColumnName("AccountId");
            this.Property(t => t.TransactionsType).HasColumnName("TransactionsType");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.PaymentType).HasColumnName("PaymentType");
            this.Property(t => t.Remarks).HasColumnName("Remarks");

            // Relationships
            this.HasRequired(t => t.Account)
                .WithMany(t => t.AccountTransactions)
                .HasForeignKey(d => d.AccountId);
            this.HasRequired(t => t.Firm)
                .WithMany(t => t.AccountTransactions)
                .HasForeignKey(d => d.FirmId);

        }
    }
}
