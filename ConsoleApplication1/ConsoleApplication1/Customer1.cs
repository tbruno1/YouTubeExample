using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Customer1
    {
        /// <summary>
        /// The Customers ID
        /// </summary>
        public string CustomerID = null;

        /// <summary>
        /// Retreive the Customer ID
        /// </summary>
        public void DisplayID()
        {
            Console.WriteLine(this.CustomerID);
        }

        /// <summary>
        /// Retrive the Customer ID and a prompt
        /// </summary>
        /// <param name="text">Prompt to prefix the Customer ID</param>
        public void DisplayID(string text)
        {
            Console.WriteLine(text + ": " + this.CustomerID);

        }
    }
}
