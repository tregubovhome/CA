namespace CA
{
    partial class Form_MoneyMoves
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MoneyMoves));
            this.cA_DB_DataSet = new CA.CA_DB_DataSet();
            this.table_MoneyMovesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_MoneyMovesTableAdapter = new CA.CA_DB_DataSetTableAdapters.Table_MoneyMovesTableAdapter();
            this.tableAdapterManager = new CA.CA_DB_DataSetTableAdapters.TableAdapterManager();
            this.table_MoneyMovesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.table_MoneyMovesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableExpensesTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_DeleteCurrent = new System.Windows.Forms.Button();
            this.button_EditCurrent = new System.Windows.Forms.Button();
            this.button_CloneCurrent = new System.Windows.Forms.Button();
            this.button_CreateNew = new System.Windows.Forms.Button();
            this.table_ExpensesTypesTableAdapter = new CA.CA_DB_DataSetTableAdapters.Table_ExpensesTypesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cA_DB_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_MoneyMovesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_MoneyMovesBindingNavigator)).BeginInit();
            this.table_MoneyMovesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_MoneyMovesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableExpensesTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cA_DB_DataSet
            // 
            this.cA_DB_DataSet.DataSetName = "CA_DB_DataSet";
            this.cA_DB_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_MoneyMovesBindingSource
            // 
            this.table_MoneyMovesBindingSource.DataMember = "Table_MoneyMoves";
            this.table_MoneyMovesBindingSource.DataSource = this.cA_DB_DataSet;
            // 
            // table_MoneyMovesTableAdapter
            // 
            this.table_MoneyMovesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Table_EmployeesTableAdapter = null;
            this.tableAdapterManager.Table_ExpensesTypesTableAdapter = null;
            this.tableAdapterManager.Table_MoneyMovesTableAdapter = this.table_MoneyMovesTableAdapter;
            this.tableAdapterManager.Table_ProjectsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CA.CA_DB_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // table_MoneyMovesBindingNavigator
            // 
            this.table_MoneyMovesBindingNavigator.AddNewItem = null;
            this.table_MoneyMovesBindingNavigator.BindingSource = this.table_MoneyMovesBindingSource;
            this.table_MoneyMovesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.table_MoneyMovesBindingNavigator.CountItemFormat = "из {0}";
            this.table_MoneyMovesBindingNavigator.DeleteItem = null;
            this.table_MoneyMovesBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.table_MoneyMovesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.table_MoneyMovesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.table_MoneyMovesBindingNavigator.Location = new System.Drawing.Point(9, 9);
            this.table_MoneyMovesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.table_MoneyMovesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.table_MoneyMovesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.table_MoneyMovesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.table_MoneyMovesBindingNavigator.Name = "table_MoneyMovesBindingNavigator";
            this.table_MoneyMovesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.table_MoneyMovesBindingNavigator.Size = new System.Drawing.Size(214, 27);
            this.table_MoneyMovesBindingNavigator.TabIndex = 0;
            this.table_MoneyMovesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 24);
            this.bindingNavigatorCountItem.Text = "из {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // table_MoneyMovesDataGridView
            // 
            this.table_MoneyMovesDataGridView.AllowUserToAddRows = false;
            this.table_MoneyMovesDataGridView.AllowUserToDeleteRows = false;
            this.table_MoneyMovesDataGridView.AllowUserToOrderColumns = true;
            this.table_MoneyMovesDataGridView.AllowUserToResizeRows = false;
            this.table_MoneyMovesDataGridView.AutoGenerateColumns = false;
            this.table_MoneyMovesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_MoneyMovesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.EmployeeName,
            this.dataGridViewTextBoxColumn7});
            this.table_MoneyMovesDataGridView.DataSource = this.table_MoneyMovesBindingSource;
            this.table_MoneyMovesDataGridView.Location = new System.Drawing.Point(9, 48);
            this.table_MoneyMovesDataGridView.MultiSelect = false;
            this.table_MoneyMovesDataGridView.Name = "table_MoneyMovesDataGridView";
            this.table_MoneyMovesDataGridView.ReadOnly = true;
            this.table_MoneyMovesDataGridView.RowTemplate.Height = 24;
            this.table_MoneyMovesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_MoneyMovesDataGridView.Size = new System.Drawing.Size(882, 220);
            this.table_MoneyMovesDataGridView.TabIndex = 1;
            this.table_MoneyMovesDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_MoneyMovesDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Sum";
            this.dataGridViewTextBoxColumn3.HeaderText = "Sum";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsCash";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsCash";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ExpensesType";
            this.dataGridViewTextBoxColumn4.HeaderText = "ExpensesType";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Project";
            this.dataGridViewTextBoxColumn5.HeaderText = "Project";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Employee";
            this.dataGridViewTextBoxColumn6.HeaderText = "Employee";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // EmployeeName
            // 
            this.EmployeeName.HeaderText = "EmployeeName";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn7.HeaderText = "Description";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // tableExpensesTypesBindingSource
            // 
            this.tableExpensesTypesBindingSource.DataMember = "Table_ExpensesTypes";
            this.tableExpensesTypesBindingSource.DataSource = this.cA_DB_DataSet;
            // 
            // button_DeleteCurrent
            // 
            this.button_DeleteCurrent.Location = new System.Drawing.Point(624, 5);
            this.button_DeleteCurrent.Name = "button_DeleteCurrent";
            this.button_DeleteCurrent.Size = new System.Drawing.Size(88, 37);
            this.button_DeleteCurrent.TabIndex = 3;
            this.button_DeleteCurrent.Text = "Удалить ...";
            this.button_DeleteCurrent.UseVisualStyleBackColor = true;
            this.button_DeleteCurrent.Click += new System.EventHandler(this.button_DeleteCurrent_Click);
            // 
            // button_EditCurrent
            // 
            this.button_EditCurrent.Location = new System.Drawing.Point(485, 5);
            this.button_EditCurrent.Name = "button_EditCurrent";
            this.button_EditCurrent.Size = new System.Drawing.Size(133, 37);
            this.button_EditCurrent.TabIndex = 4;
            this.button_EditCurrent.Text = "Редактировать ...";
            this.button_EditCurrent.UseVisualStyleBackColor = true;
            this.button_EditCurrent.Click += new System.EventHandler(this.button_EditCurrent_Click);
            // 
            // button_CloneCurrent
            // 
            this.button_CloneCurrent.Location = new System.Drawing.Point(359, 5);
            this.button_CloneCurrent.Name = "button_CloneCurrent";
            this.button_CloneCurrent.Size = new System.Drawing.Size(120, 37);
            this.button_CloneCurrent.TabIndex = 5;
            this.button_CloneCurrent.Text = "Клонировать ...";
            this.button_CloneCurrent.UseVisualStyleBackColor = true;
            this.button_CloneCurrent.Click += new System.EventHandler(this.button_CloneCurrent_Click);
            // 
            // button_CreateNew
            // 
            this.button_CreateNew.Location = new System.Drawing.Point(237, 5);
            this.button_CreateNew.Name = "button_CreateNew";
            this.button_CreateNew.Size = new System.Drawing.Size(116, 37);
            this.button_CreateNew.TabIndex = 6;
            this.button_CreateNew.Text = "Создать ...";
            this.button_CreateNew.UseVisualStyleBackColor = true;
            this.button_CreateNew.Click += new System.EventHandler(this.button_CreateNew_Click);
            // 
            // table_ExpensesTypesTableAdapter
            // 
            this.table_ExpensesTypesTableAdapter.ClearBeforeFill = true;
            // 
            // Form_MoneyMoves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 292);
            this.Controls.Add(this.button_DeleteCurrent);
            this.Controls.Add(this.button_EditCurrent);
            this.Controls.Add(this.button_CloneCurrent);
            this.Controls.Add(this.button_CreateNew);
            this.Controls.Add(this.table_MoneyMovesDataGridView);
            this.Controls.Add(this.table_MoneyMovesBindingNavigator);
            this.Name = "Form_MoneyMoves";
            this.Text = "Form_MoneyMoves";
            this.Load += new System.EventHandler(this.Form_MoneyMoves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cA_DB_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_MoneyMovesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_MoneyMovesBindingNavigator)).EndInit();
            this.table_MoneyMovesBindingNavigator.ResumeLayout(false);
            this.table_MoneyMovesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_MoneyMovesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableExpensesTypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CA_DB_DataSet cA_DB_DataSet;
        private System.Windows.Forms.BindingSource table_MoneyMovesBindingSource;
        private CA_DB_DataSetTableAdapters.Table_MoneyMovesTableAdapter table_MoneyMovesTableAdapter;
        private CA_DB_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator table_MoneyMovesBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView table_MoneyMovesDataGridView;
        private System.Windows.Forms.Button button_DeleteCurrent;
        private System.Windows.Forms.Button button_EditCurrent;
        private System.Windows.Forms.Button button_CloneCurrent;
        private System.Windows.Forms.Button button_CreateNew;
        private System.Windows.Forms.BindingSource tableExpensesTypesBindingSource;
        private CA_DB_DataSetTableAdapters.Table_ExpensesTypesTableAdapter table_ExpensesTypesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;


    }
}