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
    public partial class FormMaterial : Form
    {
        public FormMaterial()
        {
            InitializeComponent();
        }

        private void materialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.materialBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.laba6DataSet);

        }

        private void FormMaterial_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'laba6DataSet.Measures' table. You can move, or remove it, as needed.
            this.measuresTableAdapter.Fill(this.laba6DataSet.Measures);
            // TODO: This line of code loads data into the 'laba6DataSet.Material' table. You can move, or remove it, as needed.
            this.materialTableAdapter.Fill(this.laba6DataSet.Material);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.materialBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.laba6DataSet);
            // TODO: This line of code loads data into the 'laba6DataSet.Measures' table. You can move, or remove it, as needed.
            this.measuresTableAdapter.Fill(this.laba6DataSet.Measures);
            // TODO: This line of code loads data into the 'laba6DataSet.Material' table. You can move, or remove it, as needed.
            this.materialTableAdapter.Fill(this.laba6DataSet.Material);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить выбранный элемент?", "Внимание", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                foreach (DataGridViewCell cell in this.materialDataGridView.SelectedCells)
            {
                if (cell.Selected)
                {
                    this.materialDataGridView.Rows.RemoveAt(cell.RowIndex);
                        this.Validate();
                        this.materialBindingSource.EndEdit();
                        this.tableAdapterManager.UpdateAll(this.laba6DataSet);
                    }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            //this.Hide();
            //Form main = new FormMaterial();
            //main.Show();
        }
    }
}
