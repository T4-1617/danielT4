using System;
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
        int EmployeeID = 3;
        int CountCustomers;
        int CountEmployees;
        int CountSuppliers;
        bool looper = true;

        public Form1()
        {
            People = new System.Collections.ArrayList();
            UsedIDs = new bool[10000];
            InitializeComponent();

            RandomID = rnd.Next(1, 4999);
            People.Add(new Customer()
            {
                FirstName = "Bertil",
                LastName = "Håkansson",
                PhoneNumber = "070123456",
                CustomerID = RandomID
            });

            RandomID = rnd.Next(5000, 10000);
            People.Add(new Customer()
            {
                FirstName = "Emilia",
                LastName = "Andersson",
                PhoneNumber = "070654321",
                CustomerID = RandomID
            });

            People.Add(new Employee()
            {
                FirstName = "Johan",
                LastName = "Almgren",
                EmployeeID = 0001,
                Title = "idk",
                PhoneNumber = "123456789",
                Wage = "10"
            });

            People.Add(new Employee()
            {
                FirstName = "Albin",
                LastName = "Carlgren",
                EmployeeID = 0002,
                Title = "vene",
                PhoneNumber = "987654321",
                Wage = "5000"
            });

            People.Add(new Supplier
            {
                FirstName = "Lars",
                LastName = "Brandt",
                PhoneNumber = "123123123",
                Company = "Frakt o Slakt AB"
            });

            ListPeople();
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
                                People.Add(new Customer { FirstName = txbFirstName.Text, LastName = txbLastName.Text, CustomerID = RandomID, PhoneNumber = txbPhoneNumber.Text });
                                UsedIDs[RandomID] = true;
                                looper = false;
                            }
                        }

                        break;

                    case 1:
                        People.Add(new Employee { FirstName = txbFirstName.Text, LastName = txbLastName.Text, EmployeeID = EmployeeID, PhoneNumber = txbPhoneNumber.Text, Title = txbTitle.Text, Wage = txbWageEdit.Text });
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
                ListPeople();
            }
        }

        private void cbxPeopleList_SelectedIndexChanged(object sender, EventArgs e)
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

        private void lbxPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cannot edit a string
            if (lbxPeople.SelectedItem is string)
            {
                pnlEdit.Visible = false;
                return;
            }
            Person person = (Person)lbxPeople.SelectedItem;

            pnlEdit.Visible = true;
            txbFirstNameEdit.Text = person.FirstName.ToString();
            txbLastNameEdit.Text = person.LastName.ToString();
            txbPhoneNumberEdit.Text = person.PhoneNumber.ToString();

            switch (lbxPeople.SelectedItem.GetType().Name)
            {
                case "Customer":
                    Customer c = (Customer)lbxPeople.SelectedItem;
                    txbCustomerIDEdit.Text = c.CustomerID.ToString();

                    pnlEmployeeEdit.Visible = false;
                    pnlSupplierEdit.Visible = false;
                    pnlCustomerEdit.Visible = true;
                    break;

                case "Employee":
                    Employee emp = (Employee)lbxPeople.SelectedItem;
                    txbEmployeeIDEdit.Text = emp.EmployeeID.ToString();
                    txbTitleEdit.Text = emp.Title.ToString();
                    txbWageEdit.Text = emp.Wage.ToString();

                    pnlEmployeeEdit.Visible = true;
                    pnlSupplierEdit.Visible = false;
                    pnlCustomerEdit.Visible = false;
                    break;

                case "Supplier":
                    Supplier supp = (Supplier)lbxPeople.SelectedItem;
                    txbCompanyEdit.Text = supp.Company.ToString();

                    pnlEmployeeEdit.Visible = false;
                    pnlSupplierEdit.Visible = true;
                    pnlCustomerEdit.Visible = false;
                    break;

                default:
                    pnlEdit.Visible = false;
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lbxPeople.SelectedIndex >= 0)
            {
                Person person = (Person)lbxPeople.SelectedItem;
                //Customer c = (Customer)lbxPeople.SelectedItem;

                person.FirstName = txbFirstNameEdit.Text;
                person.LastName = txbLastNameEdit.Text;
                person.PhoneNumber = txbPhoneNumberEdit.Text;

                switch (lbxPeople.SelectedItem.GetType().Name)
                {
                    case "Employee":
                        Employee emp = (Employee)lbxPeople.SelectedItem;
                        emp.Title = txbTitleEdit.Text;
                        emp.Wage = txbWageEdit.Text;
                        break;

                    case "Supplier":
                        Supplier supp = (Supplier)lbxPeople.SelectedItem;
                        supp.Company = txbCompanyEdit.Text;
                        break;

                    default:
                        break;
                }
                lbxPeople.Items.Clear();
                
                foreach (Person item in People)
                {
                    lbxPeople.Items.Add(item);
                }
            }

        }
        
        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = false;
        }

        void ListPeople()
        {
            CountCustomers = 0;
            CountEmployees = 0;
            CountSuppliers = 0;

            lbxPeople.Items.Add("Customers:");

            foreach (Person item in People)
            {
                if (item is Customer)
                {
                    lbxPeople.Items.Add(item);
                    CountCustomers++;
                }
            }

            lbxPeople.Items.Add(string.Empty);
            lbxPeople.Items.Add("\nEmployees:");

            foreach (Person item in People)
            {
                if (item is Employee)
                {
                    lbxPeople.Items.Add(item);
                    CountEmployees++;
                }
            }

            lbxPeople.Items.Add(string.Empty);
            lbxPeople.Items.Add("Suppliers:");

            foreach (Person item in People)
            {
                if (item is Supplier)
                {
                    lbxPeople.Items.Add(item);
                    CountSuppliers++;
                }
            }
            lblPeopleCounter.Text = string.Format("There are {0} people listed. {1} Customers, {2} Employees, {3} Suppliers.", People.Count, CountCustomers, CountEmployees, CountSuppliers);
        }

    }
}
