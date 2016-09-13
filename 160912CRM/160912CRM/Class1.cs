using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _160912CRM
{
    public class Customer
    {
        public int CustomerID;
        public string FirstName;
        public string LastName;
        public bool Status;


        public string FullName()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }

    }
}
