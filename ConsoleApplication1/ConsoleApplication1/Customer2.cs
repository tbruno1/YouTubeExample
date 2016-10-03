using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Customer2
    {
        private string _City;
        private string _Country = _DefaultCountry;
        private string _CustomerName;
        private string _PostalCode;
        private string _Region;
        private string _CustomerID;

        /// <param name="CustomerID">ID for the new Customer</param>
        public Customer2(string CustomerID)
        {
            _CustomerID= CustomerID;
        }

        public string CustomerID
        {
            get
            {
                return _CustomerID;
            }

        }

        public string City
        {
            get
            {
                return _City;
            }

            set
            {
                _City = value;
            }
        }

        public string Country
        {
            get
            {
                return _Country;
            }

            set
            {
                _Country = value;
            }
        }

        public string CustomerName
        {
            get
            {
                return _CustomerName;
            }

            set
            {
                _CustomerName = value;
            }
        }

        public string PostalCode
        {
            get
            {
                return _PostalCode;

            }

            set
            {
                _PostalCode = value;
            }
        }

        public string Region
        {
            get
            {
                return _Region;
            }

            set
            {
                _Region = value;

            }
        }

        public void UpdateLocation(string NewCity, string NewRegion, string NewPostalCode)
        {
            _City = NewCity;
            _Region = NewRegion;
            _PostalCode = NewPostalCode;
        }

        public void UpdateLocaton(string NewCity, string NewRegion, string NewPostalCode, string NewCountry)
        {
            _City = NewCity;
            _Region = NewRegion;
            _PostalCode = NewPostalCode;
            _Country = NewCountry;
        }

        public string GetLocation()
        {
            return string.Format("{0} {1} {2}", _City, _Region, _PostalCode);
        }

        public string Location
        {
            get
            {
                return string.Format("{0} {1} {2}", _City, _Region, _PostalCode);


            }
        }
        public override string ToString()
        {
            return string.Format("{0} {1}", _CustomerID, _CustomerName);
        }

        public static string _DefaultCountry = "USA";
        public static string DefaultCountry
        {
            get { return _DefaultCountry; }
            set { _DefaultCountry = value; }
        }
    }
}