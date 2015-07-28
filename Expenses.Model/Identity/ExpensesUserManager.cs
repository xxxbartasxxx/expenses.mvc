using Microsoft.AspNet.Identity;

namespace Expenses.Model
{
    public class ExpensesUserManager<TUser> : UserManager<TUser, int> where TUser : class, IUser<int>
    {
        public ExpensesUserManager(IExpensesUserStore<TUser> store) : base(store) { }
    }
}
