using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgocShop.Data.Infrastructure
{
    public class Disposable : IDisposable
    {
        public bool IsDisposed;
        ~Disposable() 
        {
            Dispose(false);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing)
        {
            if (!IsDisposed && disposing) 
            {
                DisposeCore();
            }
            IsDisposed= true;
        }

        protected virtual void DisposeCore()
        {

        }
    }
}
