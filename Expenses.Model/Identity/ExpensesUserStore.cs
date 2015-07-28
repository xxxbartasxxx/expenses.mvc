using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;

namespace Expenses.Model
{
    public class ExpensesUserStore<TUser> : UserStore<TUser, ExpensesIdentityRole, int, ExpensesIdentityUserLogin, ExpensesIdentityUserRole, ExpensesIdentityUserClaim>, IExpensesUserStore<TUser>, IUserStore<TUser, int>, IDisposable where TUser : ExpensesIdentityUser
    {
        public ExpensesUserStore() : base(new ExpensesContext())
        {
            DisposeContext = true;
        }

        public ExpensesUserStore(DbContext context) : base(context) { }
    }
}
