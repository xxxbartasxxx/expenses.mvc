using System.Threading.Tasks;

namespace Expenses.Model
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool _disposed = false; // To detect redundant calls
        private ExpensesContext _ctx = new ExpensesContext();
        private GenericRepository<Account> _accountRepository;

        public GenericRepository<Account> AccountRepository
        {
            get
            {
                if (_accountRepository == null)
                    _accountRepository = new GenericRepository<Account>(_ctx);
                return _accountRepository;
            }
        }

        public void Save()
        {
            _ctx.SaveChanges();
        }

        public Task<int> SaveAsync()
        {
            return _ctx.SaveChangesAsync();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                    _ctx.Dispose();

                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}
