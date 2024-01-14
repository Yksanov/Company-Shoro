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
    public partial class FormRoles : Form
    {
        public FormRoles()
        {
            InitializeComponent();
        }

        private void rolesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rolesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.laba6DataSet);

        }

        private void FormRoles_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'laba6DataSet.Roles' table. You can move, or remove it, as needed.
            this.rolesTableAdapter.Fill(this.laba6DataSet.Roles);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rolesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.laba6DataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in this.rolesDataGridView.SelectedCells)
            {
                if (cell.Selected)
                {
                    this.rolesDataGridView.Rows.RemoveAt(cell.RowIndex);
                }
            }
            this.Validate();
            this.rolesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.laba6DataSet);
        }
    }
}
