using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security.DataProtection;

namespace Expenses.Model
{
    public class ExpensesDataProtectorTokenProvider<TUser> : DataProtectorTokenProvider<TUser, int> where TUser : class, IUser<int>
    {
        public ExpensesDataProtectorTokenProvider(IDataProtector protector) : base(protector) { }
    }
}
