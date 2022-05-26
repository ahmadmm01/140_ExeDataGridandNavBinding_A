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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

        }

        private void mahasiswaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mahasiswaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.prodiTIDataSet);

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
