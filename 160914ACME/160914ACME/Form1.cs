using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _160914ACME
{
    public partial class Form1 : Form
    {

        System.Collections.ArrayList MyCars = new System.Collections.ArrayList();
        Cars[] carIndex = new Cars[5];

        public Form1()
        {
            InitializeComponent();

            panel1.Visible = false;

            Cars a = new Cars { name = "Volvo V70", fuel = "Diesel", horsePowers = "170", price = "300/h", seats = "5" };
            Cars b = new Cars { name = "Audi A6", fuel = "Electricity", horsePowers = "250", price = "300/h", seats = "5" };
            Cars c = new Cars { name = "Mercedes Benz", fuel = "Diesel", horsePowers = "200", price = "250/h", seats = "5" };
            Cars d = new Cars { name = "Mazda", fuel = "Gasoline", horsePowers = "150", price = "200/h", seats = "4" };
            Cars e = new Cars { name = "Saab", fuel = "Diesel", horsePowers = "150", price = "210/h", seats = "4" };
            carIndex[0] = a;
            carIndex[1] = b;
            carIndex[2] = c;
            carIndex[3] = d;
            carIndex[4] = e;
            for (int i = 0; i < 5; i++)
            {
                MyCars.Add(carIndex[i]);
                listBox1.Items.Add(carIndex[i].name);
                
            }
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cars x = (Cars)MyCars[listBox1.SelectedIndex];
            panel1.Visible = true;
            textBox2.Text = x.fuel;
            textBox3.Text = x.horsePowers;
            textBox4.Text = x.price;
            textBox5.Text = x.seats;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            textBox5.ReadOnly = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cars x = (Cars)MyCars[listBox1.SelectedIndex];
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            x.fuel = textBox2.Text;
            x.horsePowers = textBox3.Text;
            x.price = textBox4.Text;
            x.seats = textBox5.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            textBox5.ReadOnly = false;
            panel1.Visible = false;
        }
    }
}
