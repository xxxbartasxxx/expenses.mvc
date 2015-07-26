using System;
using System.Data.Entity;
using System.Threading;

namespace Expenses.Model
{
    public abstract class ExpensesContextBase<TContext> : DbContext where TContext : DbContext
    {
        protected static int _counter = 0;
        static ExpensesContextBase()
        {
            Database.SetInitializer<TContext>(null);
        }

        protected ExpensesContextBase() : base("name=DefaultConnection")
        {
            Interlocked.Increment(ref _counter);
            System.Diagnostics.Debug.WriteLine(String.Format("Creating...{0}", _counter));
        }

        protected override void Dispose(bool disposing)
        {
            Interlocked.Decrement(ref _counter);
            System.Diagnostics.Debug.WriteLine(String.Format("Disposing...{0}", _counter));

            base.Dispose(disposing);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
