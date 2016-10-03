using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class StreamDemo
    {
        private System.IO.FileStream fs = null;

        public StreamDemo()
        { // set up fs here...

        }

        ~StreamDemo()
        {
            if (fs != null)
                fs.Close();
            Console.WriteLine("in Destructor");
        }
    }
}
