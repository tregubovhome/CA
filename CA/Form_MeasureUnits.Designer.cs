namespace CA
{
    partial class Form_MeasureUnits : Form_BaseStyle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MeasureUnits));
            this.cA_DB_DataSet = new CA.CA_DB_DataSet();
            this.table_MeasureUnitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_MeasureUnitsTableAdapter = new CA.CA_DB_DataSetTableAdapters.Table_MeasureUnitsTableAdapter();
            this.tableAdapterManager = new CA.CA_DB_DataSetTableAdapters.TableAdapterManager();
            this.table_MeasureUnitsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.table_MeasureUnitsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.table_MeasureUnitsDataGridView = new System.Windows.Forms.DataGridView();
            this.MeasureUnitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeasureUnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cA_DB_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_MeasureUnitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_MeasureUnitsBindingNavigator)).BeginInit();
            this.table_MeasureUnitsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_MeasureUnitsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cA_DB_DataSet
            // 
            this.cA_DB_DataSet.DataSetName = "CA_DB_DataSet";
            this.cA_DB_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_MeasureUnitsBindingSource
            // 
            this.table_MeasureUnitsBindingSource.DataMember = "Table_MeasureUnits";
            this.table_MeasureUnitsBindingSource.DataSource = this.cA_DB_DataSet;
            // 
            // table_MeasureUnitsTableAdapter
            // 
            this.table_MeasureUnitsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Table_CompaniesTableAdapter = null;
            this.tableAdapterManager.Table_CompanyTypesTableAdapter = null;
            this.tableAdapterManager.Table_EmployeesTableAdapter = null;
            this.tableAdapterManager.Table_HistoryTableAdapter = null;
            this.tableAdapterManager.Table_MaterialGroupsTableAdapter = null;
            this.tableAdapterManager.Table_MaterialsTableAdapter = null;
            this.tableAdapterManager.Table_MeasureUnitsTableAdapter = this.table_MeasureUnitsTableAdapter;
            this.tableAdapterManager.Table_MoneyFlowTableAdapter = null;
            this.tableAdapterManager.Table_ProductionStagesTableAdapter = null;
            this.tableAdapterManager.Table_ProjectsTableAdapter = null;
            this.tableAdapterManager.Table_ProjectStatusesTableAdapter = null;
            this.tableAdapterManager.Table_SectionsTableAdapter = null;
            this.tableAdapterManager.Table_TEOMaterialsTableAdapter = null;
            this.tableAdapterManager.Table_UsersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CA.CA_DB_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // table_MeasureUnitsBindingNavigator
            // 
            this.table_MeasureUnitsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.table_MeasureUnitsBindingNavigator.BindingSource = this.table_MeasureUnitsBindingSource;
            this.table_MeasureUnitsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.table_MeasureUnitsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.table_MeasureUnitsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.table_MeasureUnitsBindingNavigatorSaveItem,
            this.toolStripButtonDelete});
            this.table_MeasureUnitsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.table_MeasureUnitsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.table_MeasureUnitsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.table_MeasureUnitsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.table_MeasureUnitsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.table_MeasureUnitsBindingNavigator.Name = "table_MeasureUnitsBindingNavigator";
            this.table_MeasureUnitsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.table_MeasureUnitsBindingNavigator.Size = new System.Drawing.Size(282, 25);
            this.table_MeasureUnitsBindingNavigator.TabIndex = 0;
            this.table_MeasureUnitsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Visible = false;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            this.bindingNavigatorDeleteItem.Visible = false;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // table_MeasureUnitsBindingNavigatorSaveItem
            // 
            this.table_MeasureUnitsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.table_MeasureUnitsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("table_MeasureUnitsBindingNavigatorSaveItem.Image")));
            this.table_MeasureUnitsBindingNavigatorSaveItem.Name = "table_MeasureUnitsBindingNavigatorSaveItem";
            this.table_MeasureUnitsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 20);
            this.table_MeasureUnitsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.table_MeasureUnitsBindingNavigatorSaveItem.Visible = false;
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(55, 19);
            this.toolStripButtonDelete.Text = "Удалить";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // table_MeasureUnitsDataGridView
            // 
            this.table_MeasureUnitsDataGridView.AutoGenerateColumns = false;
            this.table_MeasureUnitsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.table_MeasureUnitsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_MeasureUnitsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MeasureUnitID,
            this.MeasureUnitName});
            this.table_MeasureUnitsDataGridView.DataSource = this.table_MeasureUnitsBindingSource;
            this.table_MeasureUnitsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_MeasureUnitsDataGridView.Location = new System.Drawing.Point(0, 25);
            this.table_MeasureUnitsDataGridView.MultiSelect = false;
            this.table_MeasureUnitsDataGridView.Name = "table_MeasureUnitsDataGridView";
            this.table_MeasureUnitsDataGridView.Size = new System.Drawing.Size(282, 307);
            this.table_MeasureUnitsDataGridView.TabIndex = 1;
            this.table_MeasureUnitsDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_MeasureUnitsDataGridView_CellValueChanged);
            this.table_MeasureUnitsDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.table_MeasureUnitsDataGridView_DefaultValuesNeeded);
            // 
            // MeasureUnitID
            // 
            this.MeasureUnitID.DataPropertyName = "id";
            this.MeasureUnitID.HeaderText = "id";
            this.MeasureUnitID.Name = "MeasureUnitID";
            this.MeasureUnitID.Visible = false;
            // 
            // MeasureUnitName
            // 
            this.MeasureUnitName.DataPropertyName = "Name";
            this.MeasureUnitName.HeaderText = "Единица измерения";
            this.MeasureUnitName.Name = "MeasureUnitName";
            this.MeasureUnitName.Width = 123;
            // 
            // Form_MeasureUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 332);
            this.Controls.Add(this.table_MeasureUnitsDataGridView);
            this.Controls.Add(this.table_MeasureUnitsBindingNavigator);
            this.Name = "Form_MeasureUnits";
            this.Text = "Единицы Измерения";
            this.Load += new System.EventHandler(this.Form_MeasureUnits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cA_DB_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_MeasureUnitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_MeasureUnitsBindingNavigator)).EndInit();
            this.table_MeasureUnitsBindingNavigator.ResumeLayout(false);
            this.table_MeasureUnitsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_MeasureUnitsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CA_DB_DataSet cA_DB_DataSet;
        private System.Windows.Forms.BindingSource table_MeasureUnitsBindingSource;
        private CA_DB_DataSetTableAdapters.Table_MeasureUnitsTableAdapter table_MeasureUnitsTableAdapter;
        private CA_DB_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator table_MeasureUnitsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton table_MeasureUnitsBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.DataGridView table_MeasureUnitsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeasureUnitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeasureUnitName;
    }
}