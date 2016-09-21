using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _160920CarRental2
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LastName);
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }
    }

    public class Customer : Person
    {
        public int CustomerID { get; set; }
    }

    public class Employee : Person
    {
        public int EmployeeID { get; set; }
        public string Title { get; set; }
        public string Wage { get; set; }
    }

    public class Supplier : Person
    {
        public string Company { get; set; }
    }
}
