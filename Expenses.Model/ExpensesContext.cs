using Expenses.Model.Configurations;
using System.Data.Entity;

namespace Expenses.Model
{
    public class ExpensesContext : ExpensesContextBase<ExpensesContext>
    {
        public virtual DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new AccountConfiguration());
        }
    }
}
