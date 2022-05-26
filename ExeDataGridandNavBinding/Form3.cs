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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form4 detail = new Form4();
            detail.label6.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            detail.label7.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            detail.label8.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            detail.label9.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            detail.label10.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            detail.ShowDialog();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
