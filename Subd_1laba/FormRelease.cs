﻿using System;
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
    public partial class FormRelease : Form
    {
        public FormRelease()
        {
            InitializeComponent();
        }

        private void releaseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.releaseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.laba6DataSet);

        }

        private void FormRelease_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'laba6DataSet.Measures' table. You can move, or remove it, as needed.
            this.measuresTableAdapter.Fill(this.laba6DataSet.Measures);
            // TODO: This line of code loads data into the 'laba6DataSet.Release' table. You can move, or remove it, as needed.
            this.releaseTableAdapter.Fill(this.laba6DataSet.Release);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.releaseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.laba6DataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in this.releaseDataGridView.SelectedCells)
            {
                if (cell.Selected)
                {
                    this.releaseDataGridView.Rows.RemoveAt(cell.RowIndex);
                }
            }
            this.Validate();
            this.releaseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.laba6DataSet);
        }
    }
}
