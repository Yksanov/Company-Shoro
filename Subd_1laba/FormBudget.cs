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
    public partial class FormBudget : Form
    {
        public FormBudget()
        {
            InitializeComponent();
        }

        private void budgetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.budgetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.laba6DataSet);

        }

        private void FormBudget_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'laba6DataSet.Budget' table. You can move, or remove it, as needed.
            this.budgetTableAdapter.Fill(this.laba6DataSet.Budget);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.budgetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.laba6DataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in this.budgetDataGridView.SelectedCells)
            {
                if (cell.Selected)
                {
                    this.budgetDataGridView.Rows.RemoveAt(cell.RowIndex);
                }
            }
            this.Validate();
            this.budgetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.laba6DataSet);
        }

    }
}
