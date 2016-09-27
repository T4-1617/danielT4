using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _160922OnlineBanking
{
    public class Customer
    {
        private ArrayList accounts { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal PersonalID { get; set; }

        public Account GetAccount(int AccountIndex)
        {
            return (Account)accounts[AccountIndex];
        }

        public ArrayList GetAccounts()
        {
            return accounts;
        }

        public void CreateAccount(decimal InitialDeposit, string AccName)
        {
            Account a = new Account() { AccountName = AccName };
            a.Deposit(InitialDeposit);
            accounts.Add(a);
        }

        public Customer()
        {
            accounts = new ArrayList();
        }

        public override string ToString() {
            return string.Format("{0} {1}", FirstName, LastName);
        }
    }

    public class Account  {
        public string AccountName { get; set; }
        private decimal balance = new decimal();

        public string AccountInfo
        {
            get { return string.Format("Kontot har {0} kr.", Balance); }
        }

        public decimal Balance
        {
            get { return balance; }
        }

        public void Deposit(decimal amount)
        {
            balance = balance + amount;
        }

        public void Withdraw(decimal amount)
        {
            balance = balance - amount;
        }

        public override string ToString()
        {
            return string.Format("{0}", AccountName);
        }
    }

}