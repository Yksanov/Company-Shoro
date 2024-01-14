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
    public partial class FormIngredients : Form
    {
        public FormIngredients()
        {
            InitializeComponent();
        }

        private void releaseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.releaseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.laba6DataSet);

        }

        private void FormIngredients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'laba6DataSet.Material' table. You can move, or remove it, as needed.
            this.materialTableAdapter.Fill(this.laba6DataSet.Material);
            // TODO: This line of code loads data into the 'laba6DataSet.Ingredients' table. You can move, or remove it, as needed.
            this.ingredientsTableAdapter.Fill(this.laba6DataSet.Ingredients);
            // TODO: This line of code loads data into the 'laba6DataSet.Release' table. You can move, or remove it, as needed.
            this.releaseTableAdapter.Fill(this.laba6DataSet.Release);

        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.releaseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.laba6DataSet);
            this.materialTableAdapter.Fill(this.laba6DataSet.Material);
            // TODO: This line of code loads data into the 'laba6DataSet.Ingredients' table. You can move, or remove it, as needed.
            this.ingredientsTableAdapter.Fill(this.laba6DataSet.Ingredients);
            // TODO: This line of code loads data into the 'laba6DataSet.Release' table. You can move, or remove it, as needed.
            //this.releaseTableAdapter.Fill(this.laba6DataSet.Release);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить выбранный элемент?", "Внимание", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                foreach (DataGridViewCell cell in this.ingredientsDataGridView.SelectedCells)
            {
                if(cell.Selected)
                {
                    this.ingredientsDataGridView.Rows.RemoveAt(cell.RowIndex);
                        this.Validate();
                        this.releaseBindingSource.EndEdit();
                        this.tableAdapterManager.UpdateAll(this.laba6DataSet);
                    }
            }
            //MessageBox.Show("Удалить!"); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Form main = new FormIngredients();
            //main.Show();
        }

        private void releaseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
