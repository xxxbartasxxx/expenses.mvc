using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.Model
{
    public class ExpensesIdentityRole : IdentityRole<int, ExpensesIdentityUserRole>
    {
    }
}
