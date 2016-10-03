using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class DisposeDemo : IDisposable
    {
        private System.IO.FileStream fs = null;

        private bool alreadyDisposed = false;

        public void Dispose()
        {
            if (!this.alreadyDisposed)
            {
                if (fs != null)
                    fs.Close();
                Console.WriteLine("in dispose");

                this.alreadyDisposed = true;

                GC.SuppressFinalize(this);

            }
        }
    }
}
