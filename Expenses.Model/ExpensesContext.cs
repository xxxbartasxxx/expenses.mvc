using Expenses.Model.Configurations;
using System.Data.Entity;

namespace Expenses.Model
{
    public class ExpensesContext : ExpensesContextBase<ApplicationUser, ExpensesContext>
    {
        public virtual DbSet<Account> Accounts { get; set; }

        public static ExpensesContext Create()
        {
            return new ExpensesContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new AccountConfiguration());
            modelBuilder.Configurations.Add(new ApplicationUserConfiguration());
        }
    }
}
