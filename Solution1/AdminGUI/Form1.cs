using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminGUI
{
    public partial class Form1 : Form
    {
        masterEntities MyDataBase = new masterEntities();
        public Form1()
        {
            InitializeComponent();

            DisplayArticles();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DisplayArticles()
        {
            listBox1.Items.Clear();
            foreach (var item in MyDataBase.Table)
            {
                listBox1.Items.Add(item);
            }
            listBox1.DisplayMember = "Headline";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string headline = "Demo headline";
            string content = "Demon content";

            Table MyArticle = new Table() { Headline = headline, Content = content};
            MyDataBase.Table.Add(MyArticle);
            MyDataBase.SaveChanges();

            MessageBox.Show("Goodgood yes.");
        }
    }
}
