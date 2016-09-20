﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _160920CarRental2
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        System.Collections.ArrayList People;
        bool[] UsedIDs;
        int RandomID;
        int EmployeeID = 0;
        bool looper = true;

        public Form1()
        {
            People = new System.Collections.ArrayList();
            UsedIDs = new bool[10000];
            InitializeComponent();

            RandomID = rnd.Next(1, 10000);
            People.Add(new Customer() { FirstName = "Bertil", LastName = "Håkansson", PhoneNumber = "070123456", CustomerID = RandomID });

            RandomID = rnd.Next(1, 10000);
            People.Add(new Customer() { FirstName = "Emilia", LastName = "Andersson", PhoneNumber = "070654321", CustomerID = RandomID });

            People.Add(new Employee() { FirstName = "Johan", LastName = "Almgren", EmployeeID = 0001, Title = "idk",PhoneNumber = "123456789", Wage = 10 });
            People.Add(new Employee() { FirstName = "Albin", LastName = "Carlgren", EmployeeID = 0002, Title = "vene", PhoneNumber = "987654321", Wage = 5000 });

            People.Add(new Supplier { FirstName = "Lars", LastName = "Brandt", PhoneNumber = "123123123", Company = "Frakt o Slakt AB" });

            foreach (Person item in People)
            {
                lbxPeople.Items.Add(item.FullName);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            RandomID = rnd.Next(10, 10000);
            if (txbFirstName.Text == "" || txbLastName.Text == "")
            {
                MessageBox.Show("You need to enter a First Name and a Last Name.");
            }

            else
            {
                switch (cbxPeopleList.SelectedIndex)
                {
                    case 0:
                        while (looper)
                        {
                            if (UsedIDs[RandomID] == false)
                            {
                                People.Add(new Customer { FirstName = txbFirstName.Text, LastName = txbLastName.Text, CustomerID = RandomID, PhoneNumber = txbPhoneNumber.Text});
                                UsedIDs[RandomID] = true;
                                looper = false;
                            } 
                        }

                        break;

                    case 1:
                        People.Add(new Employee { FirstName = txbFirstName.Text, LastName = txbLastName.Text, EmployeeID = EmployeeID, PhoneNumber = txbPhoneNumber.Text, Title = txbTitle.Text, Wage = int.Parse(txbWage.Text) });
                        EmployeeID++;
                        break;

                    case 2:
                        People.Add(new Supplier { FirstName = txbFirstName.Text, LastName = txbLastName.Text, Company = txbCompany.Text, PhoneNumber = txbPhoneNumber.Text });
                        break;

                    default:
                        MessageBox.Show("You need to select something to register from the list.");
                        break;
                }
                lbxPeople.Items.Clear();
                looper = true;

                foreach (Person item in People)
                {
                    lbxPeople.Items.Add(item.FullName);
                }
            }

        }

        private void cbxPeopleList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbxPeopleList.SelectedIndex)
            {
                case 1:
                    pnlEmployee.Visible = true;
                    pnlSupplier.Visible = false;
                    break;

                case 2:
                    pnlEmployee.Visible = false;
                    pnlSupplier.Visible = true;
                    break;

                default:
                    pnlEmployee.Visible = false;
                    pnlSupplier.Visible = false;
                    break;
            }
        }

        private void lbxPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxPeopleList.SelectedIndex)
            {
                case 1:
                    pnlEmployee.Visible = true;
                    pnlSupplier.Visible = false;
                    break;

                case 2:
                    pnlEmployee.Visible = false;
                    pnlSupplier.Visible = true;
                    break;

                default:
                    pnlEmployee.Visible = false;
                    pnlSupplier.Visible = false;
                    break;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlEmployee.Visible = false;
            pnlSupplier.Visible = false;
            cbxPeopleList.SelectedIndex = -1;
        }
    }
}
