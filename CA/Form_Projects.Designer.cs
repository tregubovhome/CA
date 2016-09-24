namespace CA
{
    partial class Form_Projects : Form_BaseStyle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Projects));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.table_ProjectsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.table_ProjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cA_DB_DataSet = new CA.CA_DB_DataSet();
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
            this.table_ProjectsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.table_ProjectsDataGridView = new System.Windows.Forms.DataGridView();
            this.tableCompaniesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableProjectStatusesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_ProjectsTableAdapter = new CA.CA_DB_DataSetTableAdapters.Table_ProjectsTableAdapter();
            this.tableAdapterManager = new CA.CA_DB_DataSetTableAdapters.TableAdapterManager();
            this.table_CompaniesTableAdapter = new CA.CA_DB_DataSetTableAdapters.Table_CompaniesTableAdapter();
            this.table_ProjectStatusesTableAdapter = new CA.CA_DB_DataSetTableAdapters.Table_ProjectStatusesTableAdapter();
            this.ProjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectCompaniID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ProjectMargin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectStatusID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ProjectComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_ProjectsBindingNavigator)).BeginInit();
            this.table_ProjectsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_ProjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cA_DB_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_ProjectsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableCompaniesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableProjectStatusesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.table_ProjectsBindingNavigator);
            this.splitContainer1.Panel2.Controls.Add(this.table_ProjectsDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(952, 641);
            this.splitContainer1.SplitterDistance = 118;
            this.splitContainer1.TabIndex = 0;
            // 
            // table_ProjectsBindingNavigator
            // 
            this.table_ProjectsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.table_ProjectsBindingNavigator.BindingSource = this.table_ProjectsBindingSource;
            this.table_ProjectsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.table_ProjectsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.table_ProjectsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.table_ProjectsBindingNavigatorSaveItem,
            this.toolStripButtonDelete,
            this.toolStripButtonOpen});
            this.table_ProjectsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.table_ProjectsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.table_ProjectsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.table_ProjectsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.table_ProjectsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.table_ProjectsBindingNavigator.Name = "table_ProjectsBindingNavigator";
            this.table_ProjectsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.table_ProjectsBindingNavigator.Size = new System.Drawing.Size(948, 25);
            this.table_ProjectsBindingNavigator.TabIndex = 1;
            this.table_ProjectsBindingNavigator.Text = "bindingNavigator1";
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
            // table_ProjectsBindingSource
            // 
            this.table_ProjectsBindingSource.DataMember = "Table_Projects";
            this.table_ProjectsBindingSource.DataSource = this.cA_DB_DataSet;
            // 
            // cA_DB_DataSet
            // 
            this.cA_DB_DataSet.DataSetName = "CA_DB_DataSet";
            this.cA_DB_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // table_ProjectsBindingNavigatorSaveItem
            // 
            this.table_ProjectsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.table_ProjectsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("table_ProjectsBindingNavigatorSaveItem.Image")));
            this.table_ProjectsBindingNavigatorSaveItem.Name = "table_ProjectsBindingNavigatorSaveItem";
            this.table_ProjectsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.table_ProjectsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.table_ProjectsBindingNavigatorSaveItem.Visible = false;
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(55, 22);
            this.toolStripButtonDelete.Text = "Удалить";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpen.Image")));
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(89, 22);
            this.toolStripButtonOpen.Text = "Открыть заказ";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // table_ProjectsDataGridView
            // 
            this.table_ProjectsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table_ProjectsDataGridView.AutoGenerateColumns = false;
            this.table_ProjectsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.table_ProjectsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_ProjectsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectID,
            this.ProjectNum,
            this.ProjectName,
            this.ProjectDate,
            this.ProjectCompaniID,
            this.ProjectMargin,
            this.ProjectSum,
            this.ProjectStatusID,
            this.ProjectComment});
            this.table_ProjectsDataGridView.DataSource = this.table_ProjectsBindingSource;
            this.table_ProjectsDataGridView.Location = new System.Drawing.Point(0, 25);
            this.table_ProjectsDataGridView.MultiSelect = false;
            this.table_ProjectsDataGridView.Name = "table_ProjectsDataGridView";
            this.table_ProjectsDataGridView.Size = new System.Drawing.Size(948, 491);
            this.table_ProjectsDataGridView.TabIndex = 0;
            this.table_ProjectsDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.table_ProjectsDataGridView_CellBeginEdit);
            this.table_ProjectsDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_ProjectsDataGridView_CellValueChanged);
            this.table_ProjectsDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.table_ProjectsDataGridView_DefaultValuesNeeded);
            // 
            // tableCompaniesBindingSource
            // 
            this.tableCompaniesBindingSource.DataMember = "Table_Companies";
            this.tableCompaniesBindingSource.DataSource = this.cA_DB_DataSet;
            // 
            // tableProjectStatusesBindingSource
            // 
            this.tableProjectStatusesBindingSource.DataMember = "Table_ProjectStatuses";
            this.tableProjectStatusesBindingSource.DataSource = this.cA_DB_DataSet;
            // 
            // table_ProjectsTableAdapter
            // 
            this.table_ProjectsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Table_CompaniesTableAdapter = this.table_CompaniesTableAdapter;
            this.tableAdapterManager.Table_CompanyTypesTableAdapter = null;
            this.tableAdapterManager.Table_EmployeesTableAdapter = null;
            this.tableAdapterManager.Table_HistoryTableAdapter = null;
            this.tableAdapterManager.Table_MaterialGroupsTableAdapter = null;
            this.tableAdapterManager.Table_MaterialsTableAdapter = null;
            this.tableAdapterManager.Table_MeasureUnitsTableAdapter = null;
            this.tableAdapterManager.Table_MoneyFlowTableAdapter = null;
            this.tableAdapterManager.Table_ProductionStagesTableAdapter = null;
            this.tableAdapterManager.Table_ProjectsTableAdapter = this.table_ProjectsTableAdapter;
            this.tableAdapterManager.Table_ProjectStatusesTableAdapter = this.table_ProjectStatusesTableAdapter;
            this.tableAdapterManager.Table_SectionsTableAdapter = null;
            this.tableAdapterManager.Table_TEOMaterialsTableAdapter = null;
            this.tableAdapterManager.Table_UsersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CA.CA_DB_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // table_CompaniesTableAdapter
            // 
            this.table_CompaniesTableAdapter.ClearBeforeFill = true;
            // 
            // table_ProjectStatusesTableAdapter
            // 
            this.table_ProjectStatusesTableAdapter.ClearBeforeFill = true;
            // 
            // ProjectID
            // 
            this.ProjectID.DataPropertyName = "id";
            this.ProjectID.HeaderText = "id";
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.Visible = false;
            this.ProjectID.Width = 40;
            // 
            // ProjectNum
            // 
            this.ProjectNum.DataPropertyName = "Num";
            this.ProjectNum.HeaderText = "№";
            this.ProjectNum.Name = "ProjectNum";
            this.ProjectNum.ReadOnly = true;
            this.ProjectNum.Width = 43;
            // 
            // ProjectName
            // 
            this.ProjectName.DataPropertyName = "Name";
            this.ProjectName.HeaderText = "Имя";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Width = 54;
            // 
            // ProjectDate
            // 
            this.ProjectDate.DataPropertyName = "Date";
            this.ProjectDate.HeaderText = "Дата создания";
            this.ProjectDate.Name = "ProjectDate";
            // 
            // ProjectCompaniID
            // 
            this.ProjectCompaniID.DataPropertyName = "CompanyID";
            this.ProjectCompaniID.DataSource = this.tableCompaniesBindingSource;
            this.ProjectCompaniID.DisplayMember = "Name";
            this.ProjectCompaniID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ProjectCompaniID.HeaderText = "Заказчик";
            this.ProjectCompaniID.Name = "ProjectCompaniID";
            this.ProjectCompaniID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProjectCompaniID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ProjectCompaniID.ValueMember = "id";
            this.ProjectCompaniID.Width = 80;
            // 
            // ProjectMargin
            // 
            this.ProjectMargin.DataPropertyName = "Margin";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N1";
            dataGridViewCellStyle1.NullValue = null;
            this.ProjectMargin.DefaultCellStyle = dataGridViewCellStyle1;
            this.ProjectMargin.HeaderText = "Маржа";
            this.ProjectMargin.Name = "ProjectMargin";
            this.ProjectMargin.Width = 67;
            // 
            // ProjectSum
            // 
            this.ProjectSum.DataPropertyName = "Sum";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.ProjectSum.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProjectSum.HeaderText = "Сумма";
            this.ProjectSum.Name = "ProjectSum";
            this.ProjectSum.Width = 66;
            // 
            // ProjectStatusID
            // 
            this.ProjectStatusID.DataPropertyName = "ProjectStatusID";
            this.ProjectStatusID.DataSource = this.tableProjectStatusesBindingSource;
            this.ProjectStatusID.DisplayMember = "Name";
            this.ProjectStatusID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ProjectStatusID.HeaderText = "Статус";
            this.ProjectStatusID.Name = "ProjectStatusID";
            this.ProjectStatusID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProjectStatusID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ProjectStatusID.ValueMember = "id";
            this.ProjectStatusID.Width = 66;
            // 
            // ProjectComment
            // 
            this.ProjectComment.DataPropertyName = "Comment";
            this.ProjectComment.HeaderText = "Комментарий";
            this.ProjectComment.Name = "ProjectComment";
            this.ProjectComment.Width = 102;
            // 
            // Form_Projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 641);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form_Projects";
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.Form_Projects_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_ProjectsBindingNavigator)).EndInit();
            this.table_ProjectsBindingNavigator.ResumeLayout(false);
            this.table_ProjectsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_ProjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cA_DB_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_ProjectsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableCompaniesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableProjectStatusesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private CA_DB_DataSet cA_DB_DataSet;
        private System.Windows.Forms.BindingSource table_ProjectsBindingSource;
        private CA_DB_DataSetTableAdapters.Table_ProjectsTableAdapter table_ProjectsTableAdapter;
        private CA_DB_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator table_ProjectsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton table_ProjectsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView table_ProjectsDataGridView;
        private CA_DB_DataSetTableAdapters.Table_ProjectStatusesTableAdapter table_ProjectStatusesTableAdapter;
        private System.Windows.Forms.BindingSource tableProjectStatusesBindingSource;
        private CA_DB_DataSetTableAdapters.Table_CompaniesTableAdapter table_CompaniesTableAdapter;
        private System.Windows.Forms.BindingSource tableCompaniesBindingSource;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectDate;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProjectCompaniID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectMargin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectSum;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProjectStatusID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectComment;
    }
}