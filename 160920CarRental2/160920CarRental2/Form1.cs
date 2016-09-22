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
        int CountCustomers=0;
        int CountEmployees;
        int CountSuppliers;
        bool looper = true;

        public Form1()
        {
            People = new System.Collections.ArrayList();//Creates an ArrayList that stores People.
            UsedIDs = new bool[1000];//Creates false bools to keep track of used IDs.
            InitializeComponent();

            RandomID = rnd.Next(1, 499);//Generates a random number between 1 and 499.

            People.Add(new Customer()//Adds a customer to the ArrayList "People".
            {
                FirstName = "Bertil",
                LastName = "Håkansson",
                PhoneNumber = "070123456",
                CustomerID = RandomID
            });

            RandomID = rnd.Next(500, 1000);//Generates a random number between 500 and 1000.
            People.Add(new Customer()//Adds a customer to the ArrayList "People".
            {
                FirstName = "Emilia",
                LastName = "Andersson",
                PhoneNumber = "070654321",
                CustomerID = RandomID
            });

            People.Add(new Employee()//Adds an employee to the ArrayList "People".
            {
                FirstName = "Johan",
                LastName = "Almgren",
                EmployeeID = 0001,
                Title = "idk",
                PhoneNumber = "123456789",
                Wage = "10"
            });

            People.Add(new Employee()//Adds an employee to the ArrayList "People".
            {
                FirstName = "Albin",
                LastName = "Carlgren",
                EmployeeID = 0002,
                Title = "vene",
                PhoneNumber = "987654321",
                Wage = "5000"
            });

            People.Add(new Supplier()//Adds a supplier to the ArrayList "People".
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
            //Forces the user to enter a First Name and a Last Name.
            if (txbFirstName.Text == "" || txbLastName.Text == "")
            {
                MessageBox.Show("You need to enter a First Name and a Last Name.");
            }

            else
            {
                looper = true;
                switch (cbxPeopleList.SelectedIndex)
                {

                    case 0://Adds a customer
                        while (looper)//Makes sure the same ID isn't assigned more than once.
                        {
                            RandomID = rnd.Next(10, 1000);

                            if (UsedIDs[RandomID] == false)
                            {
                                People.Add(new Customer { FirstName = txbFirstName.Text, LastName = txbLastName.Text, CustomerID = RandomID, PhoneNumber = txbPhoneNumber.Text });
                                UsedIDs[RandomID] = true;
                                CountCustomers++;
                                looper = false;
                            }
                        }
                        break;

                    case 1://Adds an employee
                        People.Add(new Employee { FirstName = txbFirstName.Text, LastName = txbLastName.Text, EmployeeID = EmployeeID, PhoneNumber = txbPhoneNumber.Text, Title = txbTitle.Text, Wage = txbWageEdit.Text });
                        EmployeeID++;
                        CountEmployees++;
                        break;

                    case 2://Adds a supplier
                        People.Add(new Supplier { FirstName = txbFirstName.Text, LastName = txbLastName.Text, Company = txbCompany.Text, PhoneNumber = txbPhoneNumber.Text });
                        CountSuppliers++;
                        break;

                    default:
                        //If none of the options in the dropdown list is selected this message will be displayed.
                        MessageBox.Show("You need to select something to register from the list.");
                        break;
                }
                lbxPeople.Items.Clear();//Clears the listbox.
                ListPeople();
                ClearTextBoxes();
            }
        }

        private void cbxPeopleList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Displays the correct panel based on what type of person is selected.
            switch (cbxPeopleList.SelectedIndex)
            {
                case 0:
                    TogglePanels(false, false);
                    break;

                case 1:
                    TogglePanels(true, false);
                    break;

                case 2:
                    TogglePanels(false, true);
                    break;

                default:
                    break;
            }
        }

        private void lbxPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cannot edit a string
            if (lbxPeople.SelectedItem is string || lbxPeople.SelectedItem == null)
            {
                pnlEdit.Visible = false;
                return;
            }
            pnlEdit.Visible = true;

            //Sets the values of "person" to the input in corresponding textbox.
            Person person = (Person)lbxPeople.SelectedItem;
            txbFirstNameEdit.Text = person.FirstName.ToString();
            txbLastNameEdit.Text = person.LastName.ToString();
            txbPhoneNumberEdit.Text = person.PhoneNumber.ToString();

            switch (lbxPeople.SelectedItem.GetType().Name)//Checks what type of person is selected.
            {
                case "Customer"://Sets the values of "c" to the input in corresponding textbox.
                    Customer c = (Customer)person;
                    txbCustomerIDEdit.Text = c.CustomerID.ToString();
                    ToggleEditPanels(false, false, true);
                    break;

                case "Employee"://Sets the values of "emp" to the input in corresponding textbox.
                    Employee emp = (Employee)person;
                    txbEmployeeIDEdit.Text = emp.EmployeeID.ToString();
                    txbTitleEdit.Text = emp.Title.ToString();
                    txbWageEdit.Text = emp.Wage.ToString();
                    ToggleEditPanels(true, false, false);
                    break;

                case "Supplier"://Sets the values of "supp" to the input in corresponding textbox.
                    Supplier supp = (Supplier)person;
                    txbCompanyEdit.Text = supp.Company.ToString();
                    ToggleEditPanels(false, true, false);
                    break;

                default://If a person is not selected the edit panel will be hidden.
                    pnlEdit.Visible = false;
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Sets the values of "person" to the input in corresponding textbox.
            Person person = (Person)lbxPeople.SelectedItem;
            person.FirstName = txbFirstNameEdit.Text;
            person.LastName = txbLastNameEdit.Text;
            person.PhoneNumber = txbPhoneNumberEdit.Text;

            switch (lbxPeople.SelectedItem.GetType().Name)//Checks what type of person is selected
            {
                case "Employee"://Sets the values of "emp" to the input in corresponding textbox.
                    Employee emp = (Employee)person;
                    emp.Title = txbTitleEdit.Text;
                    emp.Wage = txbWageEdit.Text;
                    break;

                case "Supplier"://Sets the values of "supp" to the input in corresponding textbox.
                    Supplier supp = (Supplier)person;
                    supp.Company = txbCompanyEdit.Text;
                    break;

                default:
                    break;
            }
            lbxPeople.Items.Clear();//Clears the listbox.
            ListPeople();
        }
        
        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = false;//Hides the edit panel.
        }

        public void ListPeople()//Prints an organized list of people in lbxPeople.
        {
            lbxPeople.Items.Add("Customers:");

            foreach (Person item in People)
            {
                if (item is Customer)
                {
                    lbxPeople.Items.Add(item);
                }
            }

            lbxPeople.Items.Add(string.Empty);
            lbxPeople.Items.Add("\nEmployees:");

            foreach (Person item in People)
            {
                if (item is Employee)
                {
                    lbxPeople.Items.Add(item);
                }
            }

            lbxPeople.Items.Add(string.Empty);
            lbxPeople.Items.Add("Suppliers:");

            foreach (Person item in People)
            {
                if (item is Supplier)
                {
                    lbxPeople.Items.Add(item);
                }
            }
            lblPeopleCounter.Text = string.Format("There are {0} people listed. {1} Customers, {2} Employees, {3} Suppliers.", People.Count, CountCustomers, CountEmployees, CountSuppliers);
        }

        public void ClearTextBoxes()//Clears all textboxes in the add section.
        {
            txbFirstName.Text = string.Empty;
            txbLastName.Text = string.Empty;
            txbPhoneNumber.Text = string.Empty;
            txbTitle.Text = string.Empty;
            txbWage.Text = string.Empty;
            txbCompany.Text = string.Empty;
        }

        private void TogglePanels(bool ToggleEmployeePanel, bool ToggleSupplierPanel)
        {
            pnlEmployee.Visible = ToggleEmployeePanel;
            pnlSupplier.Visible = ToggleSupplierPanel;
        }

        private void ToggleEditPanels(bool ToggleCustomerEditPanel, bool ToggleEmployeeEditPanel, bool ToggleSupplierEditPanel)
        {
            pnlCustomerEdit.Visible = ToggleCustomerEditPanel;
            pnlEmployeeEdit.Visible = ToggleEmployeeEditPanel;
            pnlSupplierEdit.Visible = ToggleSupplierEditPanel;
        }
    }
}
