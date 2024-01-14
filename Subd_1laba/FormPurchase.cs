using Subd_1laba.Models1;
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
    public partial class FormPurchase : Form
    {
        public static int amountRows = 0;
        public FormPurchase()
        {
            InitializeComponent();
        }

        private void purchaseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.purchaseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.laba6DataSet);

        }

        private void FormPurchase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'laba6DataSet.Budget' table. You can move, or remove it, as needed.
            this.budgetTableAdapter.Fill(this.laba6DataSet.Budget);
            // TODO: This line of code loads data into the 'laba6DataSet.Budget' table. You can move, or remove it, as needed.
            this.budgetTableAdapter.Fill(this.laba6DataSet.Budget); 
            // TODO: This line of code loads data into the 'laba6DataSet.Employes' table. You can move, or remove it, as needed.
            this.employesTableAdapter.Fill(this.laba6DataSet.Employes);
            // TODO: This line of code loads data into the 'laba6DataSet.Material' table. You can move, or remove it, as needed.
            this.materialTableAdapter.Fill(this.laba6DataSet.Material);
            // TODO: This line of code loads data into the 'laba6DataSet.Purchase' table. You can move, or remove it, as needed.
            this.purchaseTableAdapter.Fill(this.laba6DataSet.Purchase);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ShoroDBContext context = new ShoroDBContext())
            {
                Budget budget = context.Budget.FirstOrDefault();

                var totalCost = context.Purchase.Sum(x => x.cost);

                foreach (DataGridViewRow row in this.purchaseDataGridView.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        

                        Purchase purchase = new Purchase();
                        if (Convert.ToInt32(row.Cells[0].Value) != null && Convert.ToInt32(row.Cells[0].Value) > -1)
                        {
                            purchase = context.Purchase.FirstOrDefault(x => x.ID == Convert.ToInt32(row.Cells[0].Value));
                        }
                        else
                        {
                            context.Purchase.Add(purchase);
                        }
                        purchase.material = Convert.ToInt32(row.Cells[1].Value);


                        if (Convert.ToInt32(row.Cells[2].Value) != purchase.amount)
                        {
                            var matId = Convert.ToInt32(row.Cells[1].Value);
                            if (context.Material.FirstOrDefault(x => x.ID == matId) != null)
                            {
                                Material mat = context.Material.FirstOrDefault(x => x.ID == Convert.ToInt32(row.Cells[1].Value));
                                mat.amount = mat.amount + (Convert.ToInt32(row.Cells[2].Value) - purchase.amount);

                                Material matt = context.Material.FirstOrDefault(x => x.ID == Convert.ToInt32(row.Cells[1].Value));
                                matt.cost = matt.cost + (Convert.ToInt32(row.Cells[3].Value) - purchase.cost);
                            }
                        }
                        purchase.amount = Convert.ToInt32(row.Cells[2].Value);
                        purchase.date = Convert.ToDateTime(row.Cells[4].Value);
                        purchase.employye = Convert.ToInt32(row.Cells[5].Value);

                        if (Convert.ToDouble(row.Cells[3].Value) != purchase.cost)
                        {
                            if (Convert.ToDouble(row.Cells[3].Value) < budget.budget)
                            {
                                budget.budget = budget.budget - (Convert.ToDouble(row.Cells[3].Value) - purchase.cost);
                                Material mat = context.Material.FirstOrDefault(x => x.ID == Convert.ToInt32(row.Cells[1].Value));
                                mat.sum = mat.sum + (Convert.ToInt32(row.Cells[3].Value) - purchase.cost);
                            }
                            else
                            {
                                MessageBox.Show("Не хватает бюджета!(" + row.Cells[1].FormattedValue + ", " + row.Cells[4].FormattedValue + ")");
                            }
                        }

                        purchase.cost = Convert.ToDouble(row.Cells[3].Value);
                    }

                }
                context.SaveChanges();
            }
            this.budgetTableAdapter.Fill(this.laba6DataSet.Budget);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (ShoroDBContext context = new ShoroDBContext())
            {
                if (MessageBox.Show("Вы действительно хотите удалить выбранный элемент?", "Внимание", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    foreach (DataGridViewCell cell in this.purchaseDataGridView.SelectedCells)
                {
                    if (cell.Selected)
                    {
                        Budget budget = context.Budget.FirstOrDefault();
                        budget.budget += Convert.ToDouble(purchaseDataGridView.Rows[cell.RowIndex].Cells[3].Value);
                        this.purchaseDataGridView.Rows.RemoveAt(cell.RowIndex);
                    }
                }
            }
            this.Validate();
            this.purchaseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.laba6DataSet);
        }

        private void purchaseDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                purchaseDataGridView.Rows[e.RowIndex].Cells[4].Value = "24.02.2023";

            }
            catch (Exception asd)
            {
                Console.WriteLine(asd);
            }
        }

        private void purchaseDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                purchaseDataGridView.Rows[e.RowIndex].Cells[4].Value = "24.02.2023";

            }
            catch (Exception asd)
            {
                Console.WriteLine(asd);
            }
        }

        private void budgetTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void purchaseDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
