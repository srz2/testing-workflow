using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRZPeople
{
    public class Address
    {
        private string sz_Street;
        private string sz_City;
        private string sz_State;
        private string sz_Zipcode;

        #region "Getters and Setters"
        public string Street
        {
            get
            {
                return sz_Street;
            }
        }

        public string City
        {
            get
            {
                return sz_City;
            }
        }

        public string State
        {
            get
            {
                return sz_State;
            }
        }

        public string Zipcode
        {
            get
            {
                return sz_Zipcode;
            }
        }

        #endregion

        /// <summary>
        /// Create a street address
        /// </summary>
        /// <param name="street">Street Address</param>
        /// <param name="city">City or town</param>
        /// <param name="state">State</param>
        /// <param name="zip">Zip Code</param>
        public Address(string street, string city, string state, string zip)
        {
            sz_Street = street;
            sz_City = city;
            sz_State = state;
            sz_Zipcode = zip;
        }
    }
}
