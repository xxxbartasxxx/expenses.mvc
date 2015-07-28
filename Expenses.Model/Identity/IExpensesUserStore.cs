using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.Model
{
    public interface IExpensesUserStore<TUser> : IUserStore<TUser, int>, IDisposable where TUser : class, IUser<int>
    {
    }
}
