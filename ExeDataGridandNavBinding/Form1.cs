using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeDataGridandNavBinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtb_Username.Text == "madd" && txtb_Password.Text == "madd123" && checkBox1.Checked)
            {
                new Form2().Show();
                this.Hide();
            }
            else if (txtb_Username.Text != "madd" || txtb_Password.Text != "madd123" || !checkBox1.Checked)
            {
                MessageBox.Show("Something wrong! please check login data properly and check Terms and Condtions before login!");

                txtb_Username.Clear();
                txtb_Password.Clear();
                txtb_Username.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
