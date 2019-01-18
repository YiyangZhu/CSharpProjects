using System;
namespace MSCourse.ModuleThree_ResourceAndMemoryManagement
{
    public class ManagedWord : IDisposable
    {
        bool _isDisposed;

        public ManagedWord()
        {
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void OpenWordDocument(string filePath)
        {
            if(this._isDisposed)
            {
                throw new ObjectDisposedException("ManagedWord");
            }
        }

        protected virtual void Dispose(bool isDisposing)
        {
            if (this._isDisposed)
                return;
            if (isDisposing)
            {

            }

            this._isDisposed = true;
        }

        //Destructor
        ~ManagedWord()
        {
            Dispose(false);
        }
    }
}
