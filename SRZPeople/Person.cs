using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRZPeople
{
    public class Person
    {
        private string sz_FirstName;
        private string sz_LastName;

        private Address addr_Address;

        #region "Getters and Setters"
        public string FirstName
        {
            get
            {
                return sz_FirstName;
            }
        }
        public string LastName
        {
            get
            {
                return sz_LastName;
            }
        }
        public Address Address
        {
            get
            {
                return addr_Address;
            }
            set
            {
                addr_Address = value;
            }
        }
        #endregion

        /// <summary>
        /// Create a person
        /// </summary>
        /// <param name="firstName">The person's first name</param>
        /// <param name="lastName">The person's last name</param>
        public Person(string firstName, string lastName)
        {
            sz_FirstName = firstName;
            sz_LastName = lastName;
        }
    }
}
