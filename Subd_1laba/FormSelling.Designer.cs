namespace Subd_1laba
{
    partial class FormSelling
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.laba6DataSet = new Subd_1laba.laba6DataSet();
            this.sellingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellingTableAdapter = new Subd_1laba.laba6DataSetTableAdapters.SellingTableAdapter();
            this.tableAdapterManager = new Subd_1laba.laba6DataSetTableAdapters.TableAdapterManager();
            this.releaseTableAdapter = new Subd_1laba.laba6DataSetTableAdapters.ReleaseTableAdapter();
            this.sellingDataGridView = new System.Windows.Forms.DataGridView();
            this.releaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employesTableAdapter = new Subd_1laba.laba6DataSetTableAdapters.EmployesTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.laba6DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellingDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.releaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сохранение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Удаление";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // laba6DataSet
            // 
            this.laba6DataSet.DataSetName = "laba6DataSet";
            this.laba6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sellingBindingSource
            // 
            this.sellingBindingSource.DataMember = "Selling";
            this.sellingBindingSource.DataSource = this.laba6DataSet;
            // 
            // sellingTableAdapter
            // 
            this.sellingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BudgetTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.IngredientsTableAdapter = null;
            this.tableAdapterManager.MaterialTableAdapter = null;
            this.tableAdapterManager.MeasuresTableAdapter = null;
            this.tableAdapterManager.ProductionTableAdapter = null;
            this.tableAdapterManager.PurchaseTableAdapter = null;
            this.tableAdapterManager.ReleaseTableAdapter = this.releaseTableAdapter;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.SellingTableAdapter = this.sellingTableAdapter;
            this.tableAdapterManager.UpdateOrder = Subd_1laba.laba6DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // releaseTableAdapter
            // 
            this.releaseTableAdapter.ClearBeforeFill = true;
            // 
            // sellingDataGridView
            // 
            this.sellingDataGridView.AutoGenerateColumns = false;
            this.sellingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.sellingDataGridView.DataSource = this.sellingBindingSource;
            this.sellingDataGridView.Location = new System.Drawing.Point(12, 142);
            this.sellingDataGridView.Name = "sellingDataGridView";
            this.sellingDataGridView.RowHeadersWidth = 51;
            this.sellingDataGridView.RowTemplate.Height = 24;
            this.sellingDataGridView.Size = new System.Drawing.Size(816, 220);
            this.sellingDataGridView.TabIndex = 3;
            // 
            // releaseBindingSource
            // 
            this.releaseBindingSource.DataMember = "Release";
            this.releaseBindingSource.DataSource = this.laba6DataSet;
            // 
            // employesBindingSource
            // 
            this.employesBindingSource.DataMember = "Employes";
            this.employesBindingSource.DataSource = this.laba6DataSet;
            // 
            // employesTableAdapter
            // 
            this.employesTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(380, 401);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 45);
            this.button3.TabIndex = 4;
            this.button3.Text = "Обновите";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(270, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Продажа продукции";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Product";
            this.dataGridViewTextBoxColumn2.DataSource = this.releaseBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Продукт";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "ID";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn3.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cost";
            this.dataGridViewTextBoxColumn4.HeaderText = "Стоимость";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Employye";
            this.dataGridViewTextBoxColumn6.DataSource = this.employesBindingSource;
            this.dataGridViewTextBoxColumn6.DisplayMember = "Name";
            this.dataGridViewTextBoxColumn6.HeaderText = "Сотрдуники";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.ValueMember = "ID";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // FormSelling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 590);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.sellingDataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FormSelling";
            this.Text = "FormSelling";
            this.Load += new System.EventHandler(this.FormSelling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.laba6DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellingDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.releaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private laba6DataSet laba6DataSet;
        private System.Windows.Forms.BindingSource sellingBindingSource;
        private laba6DataSetTableAdapters.SellingTableAdapter sellingTableAdapter;
        private laba6DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private laba6DataSetTableAdapters.ReleaseTableAdapter releaseTableAdapter;
        private System.Windows.Forms.DataGridView sellingDataGridView;
        private System.Windows.Forms.BindingSource releaseBindingSource;
        private System.Windows.Forms.BindingSource employesBindingSource;
        private laba6DataSetTableAdapters.EmployesTableAdapter employesTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
    }
}