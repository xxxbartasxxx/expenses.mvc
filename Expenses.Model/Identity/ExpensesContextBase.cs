using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Threading;

namespace Expenses.Model
{
    public abstract class ExpensesContextBase<TUser, TContext> : IdentityDbContext<TUser, ExpensesIdentityRole, int, ExpensesIdentityUserLogin, ExpensesIdentityUserRole, ExpensesIdentityUserClaim>
        where TUser : ExpensesIdentityUser
        where TContext : DbContext
    {
        protected static int _counter = 0;
        static ExpensesContextBase()
        {
            Database.SetInitializer<TContext>(null);
        }

        public ExpensesContextBase() : base("name=DefaultConnection")
        {
            Interlocked.Increment(ref _counter);
            System.Diagnostics.Debug.WriteLine(String.Format("Creating...{0}", _counter));
        }

        public ExpensesContextBase(DbCompiledModel model) : base(model) { }

        public ExpensesContextBase(string nameOrConnectionString) : base(nameOrConnectionString) { }

        public ExpensesContextBase(DbConnection existingConnection, bool contextOwnsConnection) : base(existingConnection, contextOwnsConnection) { }

        public ExpensesContextBase(string nameOrConnectionString, DbCompiledModel model) : base(nameOrConnectionString, model) { }

        public ExpensesContextBase(DbConnection existingConnection, DbCompiledModel model, bool contextOwnsConnection) : base(existingConnection, model, contextOwnsConnection) { }


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
