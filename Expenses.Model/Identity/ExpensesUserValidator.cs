using Microsoft.AspNet.Identity;

namespace Expenses.Model
{
    public class ExpensesUserValidator<TUser> : UserValidator<TUser, int> where TUser : class, IUser<int>
    {
        public ExpensesUserValidator(ExpensesUserManager<TUser> manager) : base(manager) { }
    }
}
