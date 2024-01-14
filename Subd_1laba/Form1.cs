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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormIngredients form = new FormIngredients();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMaterial form = new FormMaterial();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormProduction form = new FormProduction();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormEmployes form = new FormEmployes();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormMeasures form = new FormMeasures();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormPurchase form = new FormPurchase();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormRelease form = new FormRelease();
            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormRoles form = new FormRoles();
            form.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FormSelling form = new FormSelling();
            form.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FormBudget form = new FormBudget();
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
