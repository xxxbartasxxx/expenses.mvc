using System;
using System.Threading.Tasks;

namespace Expenses.Model
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();

        Task<int> SaveAsync();
    }
}
