namespace Shyam.Shared.Base
{
    public abstract class Disposable : IDisposable
    {
        protected bool Disposed { get; private set; }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {

            }
            Disposed = true;
        }
    }
}
