namespace CA
{
    partial class Form_Employees : Form_BaseStyle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Employees));
            this.table_EmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cA_DB_DataSet = new CA.CA_DB_DataSet();
            this.table_EmployeesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_EmployeesTableAdapter = new CA.CA_DB_DataSetTableAdapters.Table_EmployeesTableAdapter();
            this.tableAdapterManager = new CA.CA_DB_DataSetTableAdapters.TableAdapterManager();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.table_EmployeesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.button_CreateNew = new System.Windows.Forms.Button();
            this.button_DeleteCurrent = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_EditCurrent = new System.Windows.Forms.Button();
            this.button_CloneCurrent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table_EmployeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cA_DB_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_EmployeesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_EmployeesBindingNavigator)).BeginInit();
            this.table_EmployeesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // table_EmployeesBindingSource
            // 
            this.table_EmployeesBindingSource.DataMember = "Table_Employees";
            this.table_EmployeesBindingSource.DataSource = this.cA_DB_DataSet;
            // 
            // cA_DB_DataSet
            // 
            this.cA_DB_DataSet.DataSetName = "CA_DB_DataSet";
            this.cA_DB_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_EmployeesDataGridView
            // 
            this.table_EmployeesDataGridView.AllowUserToAddRows = false;
            this.table_EmployeesDataGridView.AllowUserToDeleteRows = false;
            this.table_EmployeesDataGridView.AllowUserToOrderColumns = true;
            this.table_EmployeesDataGridView.AllowUserToResizeRows = false;
            this.table_EmployeesDataGridView.AutoGenerateColumns = false;
            this.table_EmployeesDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.table_EmployeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_EmployeesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.table_EmployeesDataGridView.DataSource = this.table_EmployeesBindingSource;
            this.table_EmployeesDataGridView.Location = new System.Drawing.Point(12, 52);
            this.table_EmployeesDataGridView.MultiSelect = false;
            this.table_EmployeesDataGridView.Name = "table_EmployeesDataGridView";
            this.table_EmployeesDataGridView.ReadOnly = true;
            this.table_EmployeesDataGridView.RowTemplate.Height = 24;
            this.table_EmployeesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_EmployeesDataGridView.Size = new System.Drawing.Size(870, 331);
            this.table_EmployeesDataGridView.TabIndex = 1;
            this.table_EmployeesDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_EmployeesDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 300;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn2.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn3.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MiddleName";
            this.dataGridViewTextBoxColumn4.HeaderText = "MiddleName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // table_EmployeesTableAdapter
            // 
            this.table_EmployeesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Table_EmployeesTableAdapter = this.table_EmployeesTableAdapter;
            this.tableAdapterManager.Table_ExpensesTypesTableAdapter = null;
            this.tableAdapterManager.Table_MoneyMovesTableAdapter = null;
            this.tableAdapterManager.Table_ProjectsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CA.CA_DB_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(47, 24);
            this.bindingNavigatorCountItem.Text = "из {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // table_EmployeesBindingNavigator
            // 
            this.table_EmployeesBindingNavigator.AddNewItem = null;
            this.table_EmployeesBindingNavigator.BindingSource = this.table_EmployeesBindingSource;
            this.table_EmployeesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.table_EmployeesBindingNavigator.CountItemFormat = "из {0}";
            this.table_EmployeesBindingNavigator.DeleteItem = null;
            this.table_EmployeesBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.table_EmployeesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.table_EmployeesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem});
            this.table_EmployeesBindingNavigator.Location = new System.Drawing.Point(9, 9);
            this.table_EmployeesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.table_EmployeesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.table_EmployeesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.table_EmployeesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.table_EmployeesBindingNavigator.Name = "table_EmployeesBindingNavigator";
            this.table_EmployeesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.table_EmployeesBindingNavigator.Size = new System.Drawing.Size(219, 27);
            this.table_EmployeesBindingNavigator.TabIndex = 0;
            this.table_EmployeesBindingNavigator.Text = "bindingNavigator1";
            // 
            // button_CreateNew
            // 
            this.button_CreateNew.Location = new System.Drawing.Point(307, 9);
            this.button_CreateNew.Name = "button_CreateNew";
            this.button_CreateNew.Size = new System.Drawing.Size(116, 37);
            this.button_CreateNew.TabIndex = 2;
            this.button_CreateNew.Text = "Создать ...";
            this.button_CreateNew.UseVisualStyleBackColor = true;
            this.button_CreateNew.Click += new System.EventHandler(this.button_CreateNew_Click);
            // 
            // button_DeleteCurrent
            // 
            this.button_DeleteCurrent.Location = new System.Drawing.Point(694, 9);
            this.button_DeleteCurrent.Name = "button_DeleteCurrent";
            this.button_DeleteCurrent.Size = new System.Drawing.Size(88, 37);
            this.button_DeleteCurrent.TabIndex = 2;
            this.button_DeleteCurrent.Text = "Удалить ...";
            this.button_DeleteCurrent.UseVisualStyleBackColor = true;
            this.button_DeleteCurrent.Click += new System.EventHandler(this.button_DeleteCurrent_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(807, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_EditCurrent
            // 
            this.button_EditCurrent.Location = new System.Drawing.Point(555, 9);
            this.button_EditCurrent.Name = "button_EditCurrent";
            this.button_EditCurrent.Size = new System.Drawing.Size(133, 37);
            this.button_EditCurrent.TabIndex = 2;
            this.button_EditCurrent.Text = "Редактировать ...";
            this.button_EditCurrent.UseVisualStyleBackColor = true;
            this.button_EditCurrent.Click += new System.EventHandler(this.button_EditCurrent_Click);
            // 
            // button_CloneCurrent
            // 
            this.button_CloneCurrent.Location = new System.Drawing.Point(429, 9);
            this.button_CloneCurrent.Name = "button_CloneCurrent";
            this.button_CloneCurrent.Size = new System.Drawing.Size(120, 37);
            this.button_CloneCurrent.TabIndex = 2;
            this.button_CloneCurrent.Text = "Клонировать ...";
            this.button_CloneCurrent.UseVisualStyleBackColor = true;
            this.button_CloneCurrent.Click += new System.EventHandler(this.button_CloneCurrent_Click);
            // 
            // Form_Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 392);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_DeleteCurrent);
            this.Controls.Add(this.button_EditCurrent);
            this.Controls.Add(this.button_CloneCurrent);
            this.Controls.Add(this.button_CreateNew);
            this.Controls.Add(this.table_EmployeesDataGridView);
            this.Controls.Add(this.table_EmployeesBindingNavigator);
            this.Name = "Form_Employees";
            this.Text = "Form_Employees";
            this.Load += new System.EventHandler(this.Form_Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_EmployeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cA_DB_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_EmployeesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_EmployeesBindingNavigator)).EndInit();
            this.table_EmployeesBindingNavigator.ResumeLayout(false);
            this.table_EmployeesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CA_DB_DataSet cA_DB_DataSet;
        private System.Windows.Forms.BindingSource table_EmployeesBindingSource;
        private CA_DB_DataSetTableAdapters.Table_EmployeesTableAdapter table_EmployeesTableAdapter;
        private CA_DB_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView table_EmployeesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.BindingNavigator table_EmployeesBindingNavigator;
        private System.Windows.Forms.Button button_CreateNew;
        private System.Windows.Forms.Button button_DeleteCurrent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_EditCurrent;
        private System.Windows.Forms.Button button_CloneCurrent;
    }
}