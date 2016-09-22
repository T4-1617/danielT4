using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _160922OnlineBanking
{
    public abstract class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonalID { get; set; }
    }

    public class Account : Customer {
        public long Balance { get; set; }
        System.Collections.ArrayList Transactions = new System.Collections.ArrayList();
    }
}