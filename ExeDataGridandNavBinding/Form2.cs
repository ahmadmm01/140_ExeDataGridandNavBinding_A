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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Form3().Show(this);
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Form5().Show(this);
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }
    }
}
