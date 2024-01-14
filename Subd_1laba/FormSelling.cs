using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subd_1laba
{
    public partial class FormSelling : Form
    {
        public FormSelling()
        {
            InitializeComponent();
        }

        private void sellingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sellingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.laba6DataSet);

        }

        private void FormSelling_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'laba6DataSet.Employes' table. You can move, or remove it, as needed.
            this.employesTableAdapter.Fill(this.laba6DataSet.Employes);
            // TODO: This line of code loads data into the 'laba6DataSet.Release' table. You can move, or remove it, as needed.
            this.releaseTableAdapter.Fill(this.laba6DataSet.Release);
            // TODO: This line of code loads data into the 'laba6DataSet.Selling' table. You can move, or remove it, as needed.
            this.sellingTableAdapter.Fill(this.laba6DataSet.Selling);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sellingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.laba6DataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in this.sellingDataGridView.SelectedCells)
            {
                if (cell.Selected)
                {
                    this.sellingDataGridView.Rows.RemoveAt(cell.RowIndex);
                }
            }
            this.Validate();
            this.sellingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.laba6DataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form main = new FormSelling();
            main.Show();
        }
    }
}
