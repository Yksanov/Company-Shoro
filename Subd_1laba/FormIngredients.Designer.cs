namespace Subd_1laba
{
    partial class FormIngredients
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
            this.laba6DataSet = new Subd_1laba.laba6DataSet();
            this.releaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.releaseTableAdapter = new Subd_1laba.laba6DataSetTableAdapters.ReleaseTableAdapter();
            this.tableAdapterManager = new Subd_1laba.laba6DataSetTableAdapters.TableAdapterManager();
            this.ingredientsTableAdapter = new Subd_1laba.laba6DataSetTableAdapters.IngredientsTableAdapter();
            this.materialTableAdapter = new Subd_1laba.laba6DataSetTableAdapters.MaterialTableAdapter();
            this.releaseComboBox = new System.Windows.Forms.ComboBox();
            this.ingredientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ingredientsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.releaseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Save = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.laba6DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.releaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.releaseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // laba6DataSet
            // 
            this.laba6DataSet.DataSetName = "laba6DataSet";
            this.laba6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // releaseBindingSource
            // 
            this.releaseBindingSource.DataMember = "Release";
            this.releaseBindingSource.DataSource = this.laba6DataSet;
            // 
            // releaseTableAdapter
            // 
            this.releaseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BudgetTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.IngredientsTableAdapter = this.ingredientsTableAdapter;
            this.tableAdapterManager.MaterialTableAdapter = this.materialTableAdapter;
            this.tableAdapterManager.MeasuresTableAdapter = null;
            this.tableAdapterManager.ProductionTableAdapter = null;
            this.tableAdapterManager.PurchaseTableAdapter = null;
            this.tableAdapterManager.ReleaseTableAdapter = this.releaseTableAdapter;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.SellingTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Subd_1laba.laba6DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ingredientsTableAdapter
            // 
            this.ingredientsTableAdapter.ClearBeforeFill = true;
            // 
            // materialTableAdapter
            // 
            this.materialTableAdapter.ClearBeforeFill = true;
            // 
            // releaseComboBox
            // 
            this.releaseComboBox.DataSource = this.releaseBindingSource;
            this.releaseComboBox.DisplayMember = "Name";
            this.releaseComboBox.FormattingEnabled = true;
            this.releaseComboBox.Location = new System.Drawing.Point(450, 66);
            this.releaseComboBox.Name = "releaseComboBox";
            this.releaseComboBox.Size = new System.Drawing.Size(300, 24);
            this.releaseComboBox.TabIndex = 1;
            this.releaseComboBox.ValueMember = "ID";
            this.releaseComboBox.SelectedIndexChanged += new System.EventHandler(this.releaseComboBox_SelectedIndexChanged);
            // 
            // ingredientsBindingSource
            // 
            this.ingredientsBindingSource.DataMember = "FK_Ingredients_Release";
            this.ingredientsBindingSource.DataSource = this.releaseBindingSource;
            // 
            // ingredientsDataGridView
            // 
            this.ingredientsDataGridView.AutoGenerateColumns = false;
            this.ingredientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ingredientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.ingredientsDataGridView.DataSource = this.ingredientsBindingSource;
            this.ingredientsDataGridView.Location = new System.Drawing.Point(39, 105);
            this.ingredientsDataGridView.Name = "ingredientsDataGridView";
            this.ingredientsDataGridView.RowHeadersWidth = 51;
            this.ingredientsDataGridView.RowTemplate.Height = 24;
            this.ingredientsDataGridView.Size = new System.Drawing.Size(711, 255);
            this.ingredientsDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Product";
            this.dataGridViewTextBoxColumn2.DataSource = this.releaseBindingSource1;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Product";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "ID";
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // releaseBindingSource1
            // 
            this.releaseBindingSource1.DataMember = "Release";
            this.releaseBindingSource1.DataSource = this.laba6DataSet;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Material";
            this.dataGridViewTextBoxColumn3.DataSource = this.materialBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Сырье";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "ID";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataMember = "Material";
            this.materialBindingSource.DataSource = this.laba6DataSet;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn4.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(39, 409);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(85, 45);
            this.Save.TabIndex = 3;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(252, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ингредиенты";
            // 
            // FormIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.ingredientsDataGridView);
            this.Controls.Add(this.releaseComboBox);
            this.Name = "FormIngredients";
            this.Text = "FormIngredients";
            this.Load += new System.EventHandler(this.FormIngredients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.laba6DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.releaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.releaseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private laba6DataSet laba6DataSet;
        private System.Windows.Forms.BindingSource releaseBindingSource;
        private laba6DataSetTableAdapters.ReleaseTableAdapter releaseTableAdapter;
        private laba6DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox releaseComboBox;
        private laba6DataSetTableAdapters.IngredientsTableAdapter ingredientsTableAdapter;
        private System.Windows.Forms.BindingSource ingredientsBindingSource;
        private laba6DataSetTableAdapters.MaterialTableAdapter materialTableAdapter;
        private System.Windows.Forms.DataGridView ingredientsDataGridView;
        private System.Windows.Forms.BindingSource releaseBindingSource1;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}