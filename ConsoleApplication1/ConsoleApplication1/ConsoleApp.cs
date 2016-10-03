using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ConsoleApp
    {
        /// <summary>
        /// Main demo
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Customer1 custA = new Customer1();
            //Customer1 custB = new Customer1();

            //custA.CustomerID = "AAAA";
            //custB.CustomerID = "BBBB";

            //Console.WriteLine("CustA customerid = " + custA.CustomerID);
            //Console.WriteLine("CustB customerid = " + custB.CustomerID);

            //custA.DisplayID();
            //custB.DisplayID();

            //custA.DisplayID("custa");

            //Customer2 custA = new Customer2("AAAA");
            //Customer2 custB = new Customer2("BBBB");

            //custA.CustomerName = "Maria god";
            //custB.CustomerName = "John Doe";

            //custA.UpdateLocation("newyour", "new uork", "10010");

            //custB.UpdateLocaton("toronto", "Ontario", "AX2FD3","CAN");


            //Console.WriteLine(custA.GetLocation());
            //Console.WriteLine(custA.Country);

            //Console.WriteLine(custB.Location);
            //Console.WriteLine(custB.Country);

            //StreamDemo x = new StreamDemo();
            //x = null;

            //GC.Collect();

            //DisposeDemo demo = null;

            //try
            //{
            //    demo = new DisposeDemo();
            //}
            //finally
            //{
            //    if (demo != null)
            //    {
            //        demo.Dispose();

            //    } }

            //using (DisposeDemo demo = new DisposeDemo())
            //{

            //}

            //Customer2 cust = new Customer2("AAAA");
            //cust.CustomerName = "John Doe";
            //Console.WriteLine(cust.ToString());


            //int intA = 10;
            //int intB = 0;

            //Console.WriteLine("before  A={0}, B={1}", intA, intB);

            //intB = intA;

            //intB = 15;

            //Console.WriteLine("after  A={0}, B={1}", intA, intB);


            //Customer2 custA = new Customer2("AAAA");
            //Customer2 custB = null;

            //custA.CustomerName = "John Doe";
            //Console.WriteLine("Before {0}", custA.ToString());

            //custB = custA;

            //custB.CustomerName = "Mary Jane";

            //Console.WriteLine("After {0}", custA.ToString());

            //string value = "ABCDE";

            //int pos = value.IndexOf("B");
            //Console.WriteLine("pos = {0}", pos);

            //Console.WriteLine(
            //    String.Concat("Concatenate ", "these ", "Together"));



            //Customer2 custA = new Customer2("AAAA");
            //Console.WriteLine("custA.Country = " + custA.Country);

            //Customer2.DefaultCountry = "UK";
            //Customer2 custB = new Customer2("BBBB");
            //Console.WriteLine("custA.Country = " + custA.Country);
            //Console.WriteLine("custB.Country = " + custB.Country);

            Customer2 someCustomer = new Customer2("AAA");
            someCustomer.CustomerName = "Application Developer Training Company";
            someCustomer.City = "Eden Prairie";
            someCustomer.Region = "MN";
            someCustomer.PostalCode = "55344";

            Console.WriteLine("Customer info");
            Console.WriteLine(someCustomer.CustomerName);
            Console.WriteLine(someCustomer.Location);
            Console.WriteLine(someCustomer.Country);

            Console.WriteLine();







        }
    }
}
