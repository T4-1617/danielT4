using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _160916CarRental
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public bool Rented { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNum { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }

        public string MoreInfo()
        {
            return string.Format("Name: {0} {1}\nEmail: {2}\nPhone Number: {3}\nAddress 1: {4}\nAddress 2: {5}", FirstName, LastName, Email, PhoneNum, Address1, Address2);
        }

        public string FullName()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }

        public override string ToString()
        {
            return string.Format("{0} {1} ({2})", Make, Model, Colour);
        }
    }
}
