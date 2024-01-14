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
    public partial class FormProduction : Form
    {
        public FormProduction()
        {
            InitializeComponent();
        }

        private void productionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.laba6DataSet);

        }

        private void FormProduction_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'laba6DataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.laba6DataSet.Employees);
            // TODO: This line of code loads data into the 'laba6DataSet.Release' table. You can move, or remove it, as needed.
            this.releaseTableAdapter.Fill(this.laba6DataSet.Release);
            // TODO: This line of code loads data into the 'laba6DataSet.Production' table. You can move, or remove it, as needed.
            this.productionTableAdapter.Fill(this.laba6DataSet.Production);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.laba6DataSet);

            // TODO: This line of code loads data into the 'laba6DataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.laba6DataSet.Employees);
            // TODO: This line of code loads data into the 'laba6DataSet.Release' table. You can move, or remove it, as needed.
            this.releaseTableAdapter.Fill(this.laba6DataSet.Release);
            // TODO: This line of code loads data into the 'laba6DataSet.Production' table. You can move, or remove it, as needed.
            this.productionTableAdapter.Fill(this.laba6DataSet.Production);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить выбранный элемент?", "Внимание", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                foreach (DataGridViewCell cell in this.productionDataGridView.SelectedCells)
            {
                if (cell.Selected)
                {
                    this.productionDataGridView.Rows.RemoveAt(cell.RowIndex);
                        this.Validate();
                        this.productionBindingSource.EndEdit();
                        this.tableAdapterManager.UpdateAll(this.laba6DataSet);
                    }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Form main = new FormProduction();
            //main.Show();
        }
    }
}
