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
    public partial class FormEmployes : Form
    {
        public FormEmployes()
        {
            InitializeComponent();
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.laba6DataSet);

        }

        private void FormEmployes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'laba6DataSet.Roles' table. You can move, or remove it, as needed.
            this.rolesTableAdapter.Fill(this.laba6DataSet.Roles);
            // TODO: This line of code loads data into the 'laba6DataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.laba6DataSet.Employees);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.laba6DataSet);
            // TODO: This line of code loads data into the 'laba6DataSet.Roles' table. You can move, or remove it, as needed.
            this.rolesTableAdapter.Fill(this.laba6DataSet.Roles);
            // TODO: This line of code loads data into the 'laba6DataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.laba6DataSet.Employees);
            //this.Hide();
            //Form main = new FormEmployes();
            //main.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить выбранный элемент?", "Внимание", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                foreach (DataGridViewCell cell in this.employeesDataGridView.SelectedCells)
            {
                if (cell.Selected)
                {
                    this.employeesDataGridView.Rows.RemoveAt(cell.RowIndex);
                        this.Validate();
                        this.employeesBindingSource.EndEdit();
                        this.tableAdapterManager.UpdateAll(this.laba6DataSet);
                 }
            }
            
            //MessageBox.Show("Удалить!");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Form main = new FormEmployes();
            //main.Show();
          // MessageBox.Show("Обновлен");
        }
    }
}
