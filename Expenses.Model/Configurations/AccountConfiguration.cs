using System.Data.Entity.ModelConfiguration;

namespace Expenses.Model.Configurations
{
    class AccountConfiguration : EntityTypeConfiguration<Account>
    {
        public AccountConfiguration()
        {
            Property(o => o.Balance).HasPrecision(18, 4);
        }
    }
}
