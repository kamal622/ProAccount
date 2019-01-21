using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using ProAccount.Data.Models.Mapping;

namespace ProAccount.Data.Models
{
    public partial class ProAccountContext : DbContext
    {
        static ProAccountContext()
        {
            Database.SetInitializer<ProAccountContext>(null);
        }

        public ProAccountContext()
            : base("Name=ProAccountContext")
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountTransaction> AccountTransactions { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<ChequeDetail> ChequeDetails { get; set; }
        public DbSet<Firm> Firms { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AccountMap());
            modelBuilder.Configurations.Add(new AccountTransactionMap());
            modelBuilder.Configurations.Add(new AccountTypeMap());
            modelBuilder.Configurations.Add(new ChequeDetailMap());
            modelBuilder.Configurations.Add(new FirmMap());
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
