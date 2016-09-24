namespace CA
{
    partial class Form_ProjectCurrent : Form_BaseStyle 
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label numLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label companyIDLabel;
            System.Windows.Forms.Label marginLabel;
            System.Windows.Forms.Label sumLabel;
            System.Windows.Forms.Label projectStatusIDLabel;
            System.Windows.Forms.Label commentLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.table_ProjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cA_DB_DataSet = new CA.CA_DB_DataSet();
            this.tableCompaniesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableProjectStatusesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.companyIDTextBox = new System.Windows.Forms.TextBox();
            this.projectStatusIDTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.marginTextBox = new System.Windows.Forms.TextBox();
            this.sumTextBox = new System.Windows.Forms.TextBox();
            this.numTextBox = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_TEO = new System.Windows.Forms.TabPage();
            this.table_TEOMaterialsDataGridView = new System.Windows.Forms.DataGridView();
            this.TEOMaterialID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEOMaterialProjectID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tableProjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TEOMaterialMaterialID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tableMaterialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TEOMaterialSupplierID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tableCompaniesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TEOMaterialPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEOMaterialCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_TEOMaterialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage_ProductionStages = new System.Windows.Forms.TabPage();
            this.table_ProductionStagesDataGridView = new System.Windows.Forms.DataGridView();
            this.ProductionStageID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductionStageProjectID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tableProjectsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ProductionStageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductionStageDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductionStageDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_ProductionStagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_ProjectsTableAdapter = new CA.CA_DB_DataSetTableAdapters.Table_ProjectsTableAdapter();
            this.tableAdapterManager = new CA.CA_DB_DataSetTableAdapters.TableAdapterManager();
            this.table_ProductionStagesTableAdapter = new CA.CA_DB_DataSetTableAdapters.Table_ProductionStagesTableAdapter();
            this.table_TEOMaterialsTableAdapter = new CA.CA_DB_DataSetTableAdapters.Table_TEOMaterialsTableAdapter();
            this.table_MaterialsTableAdapter = new CA.CA_DB_DataSetTableAdapters.Table_MaterialsTableAdapter();
            this.table_CompaniesTableAdapter = new CA.CA_DB_DataSetTableAdapters.Table_CompaniesTableAdapter();
            this.table_ProjectStatusesTableAdapter = new CA.CA_DB_DataSetTableAdapters.Table_ProjectStatusesTableAdapter();
            this.button_Refresh = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            numLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            companyIDLabel = new System.Windows.Forms.Label();
            marginLabel = new System.Windows.Forms.Label();
            sumLabel = new System.Windows.Forms.Label();
            projectStatusIDLabel = new System.Windows.Forms.Label();
            commentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_ProjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cA_DB_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableCompaniesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableProjectStatusesBindingSource)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage_TEO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_TEOMaterialsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableProjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableMaterialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableCompaniesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_TEOMaterialsBindingSource)).BeginInit();
            this.tabPage_ProductionStages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_ProductionStagesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableProjectsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_ProductionStagesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(244, 107);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "id:";
            idLabel.Visible = false;
            // 
            // numLabel
            // 
            numLabel.AutoSize = true;
            numLabel.Location = new System.Drawing.Point(23, 43);
            numLabel.Name = "numLabel";
            numLabel.Size = new System.Drawing.Size(32, 13);
            numLabel.TabIndex = 2;
            numLabel.Text = "Num:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(23, 18);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(188, 44);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 6;
            dateLabel.Text = "Date:";
            // 
            // companyIDLabel
            // 
            companyIDLabel.AutoSize = true;
            companyIDLabel.Location = new System.Drawing.Point(23, 67);
            companyIDLabel.Name = "companyIDLabel";
            companyIDLabel.Size = new System.Drawing.Size(68, 13);
            companyIDLabel.TabIndex = 8;
            companyIDLabel.Text = "Company ID:";
            // 
            // marginLabel
            // 
            marginLabel.AutoSize = true;
            marginLabel.Location = new System.Drawing.Point(23, 94);
            marginLabel.Name = "marginLabel";
            marginLabel.Size = new System.Drawing.Size(42, 13);
            marginLabel.TabIndex = 10;
            marginLabel.Text = "Margin:";
            // 
            // sumLabel
            // 
            sumLabel.AutoSize = true;
            sumLabel.Location = new System.Drawing.Point(23, 119);
            sumLabel.Name = "sumLabel";
            sumLabel.Size = new System.Drawing.Size(31, 13);
            sumLabel.TabIndex = 12;
            sumLabel.Text = "Sum:";
            // 
            // projectStatusIDLabel
            // 
            projectStatusIDLabel.AutoSize = true;
            projectStatusIDLabel.Location = new System.Drawing.Point(23, 142);
            projectStatusIDLabel.Name = "projectStatusIDLabel";
            projectStatusIDLabel.Size = new System.Drawing.Size(90, 13);
            projectStatusIDLabel.TabIndex = 14;
            projectStatusIDLabel.Text = "Project Status ID:";
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.Location = new System.Drawing.Point(23, 169);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(54, 13);
            commentLabel.TabIndex = 16;
            commentLabel.Text = "Comment:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button_Refresh);
            this.splitContainer1.Size = new System.Drawing.Size(968, 635);
            this.splitContainer1.SplitterDistance = 745;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.comboBox2);
            this.splitContainer3.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer3.Panel1.Controls.Add(idLabel);
            this.splitContainer3.Panel1.Controls.Add(commentLabel);
            this.splitContainer3.Panel1.Controls.Add(companyIDLabel);
            this.splitContainer3.Panel1.Controls.Add(this.commentTextBox);
            this.splitContainer3.Panel1.Controls.Add(this.dateDateTimePicker);
            this.splitContainer3.Panel1.Controls.Add(this.companyIDTextBox);
            this.splitContainer3.Panel1.Controls.Add(this.projectStatusIDTextBox);
            this.splitContainer3.Panel1.Controls.Add(dateLabel);
            this.splitContainer3.Panel1.Controls.Add(this.idTextBox);
            this.splitContainer3.Panel1.Controls.Add(marginLabel);
            this.splitContainer3.Panel1.Controls.Add(projectStatusIDLabel);
            this.splitContainer3.Panel1.Controls.Add(this.nameTextBox);
            this.splitContainer3.Panel1.Controls.Add(numLabel);
            this.splitContainer3.Panel1.Controls.Add(this.marginTextBox);
            this.splitContainer3.Panel1.Controls.Add(this.sumTextBox);
            this.splitContainer3.Panel1.Controls.Add(nameLabel);
            this.splitContainer3.Panel1.Controls.Add(this.numTextBox);
            this.splitContainer3.Panel1.Controls.Add(sumLabel);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.AutoScroll = true;
            this.splitContainer3.Panel2.Controls.Add(this.tabControl);
            this.splitContainer3.Size = new System.Drawing.Size(745, 635);
            this.splitContainer3.SplitterDistance = 218;
            this.splitContainer3.TabIndex = 18;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.table_ProjectsBindingSource, "CompanyID", true));
            this.comboBox2.DataSource = this.tableCompaniesBindingSource1;
            this.comboBox2.DisplayMember = "Name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(119, 65);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 18;
            this.comboBox2.ValueMember = "id";
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
            // tableCompaniesBindingSource1
            // 
            this.tableCompaniesBindingSource1.DataMember = "Table_Companies";
            this.tableCompaniesBindingSource1.DataSource = this.cA_DB_DataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.table_ProjectsBindingSource, "ProjectStatusID", true));
            this.comboBox1.DataSource = this.tableProjectStatusesBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(119, 139);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.ValueMember = "id";
            // 
            // tableProjectStatusesBindingSource
            // 
            this.tableProjectStatusesBindingSource.DataMember = "Table_ProjectStatuses";
            this.tableProjectStatusesBindingSource.DataSource = this.cA_DB_DataSet;
            // 
            // commentTextBox
            // 
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_ProjectsBindingSource, "Comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(119, 166);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(200, 43);
            this.commentTextBox.TabIndex = 17;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.table_ProjectsBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(227, 40);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(119, 19);
            this.dateDateTimePicker.TabIndex = 7;
            // 
            // companyIDTextBox
            // 
            this.companyIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_ProjectsBindingSource, "CompanyID", true));
            this.companyIDTextBox.Location = new System.Drawing.Point(246, 67);
            this.companyIDTextBox.Name = "companyIDTextBox";
            this.companyIDTextBox.Size = new System.Drawing.Size(200, 19);
            this.companyIDTextBox.TabIndex = 9;
            this.companyIDTextBox.Visible = false;
            // 
            // projectStatusIDTextBox
            // 
            this.projectStatusIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_ProjectsBindingSource, "ProjectStatusID", true));
            this.projectStatusIDTextBox.Location = new System.Drawing.Point(246, 139);
            this.projectStatusIDTextBox.Name = "projectStatusIDTextBox";
            this.projectStatusIDTextBox.Size = new System.Drawing.Size(200, 19);
            this.projectStatusIDTextBox.TabIndex = 15;
            this.projectStatusIDTextBox.Visible = false;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_ProjectsBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(268, 104);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(33, 19);
            this.idTextBox.TabIndex = 1;
            this.idTextBox.Visible = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_ProjectsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(119, 15);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(368, 19);
            this.nameTextBox.TabIndex = 5;
            // 
            // marginTextBox
            // 
            this.marginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_ProjectsBindingSource, "Margin", true));
            this.marginTextBox.Location = new System.Drawing.Point(119, 91);
            this.marginTextBox.Name = "marginTextBox";
            this.marginTextBox.Size = new System.Drawing.Size(60, 19);
            this.marginTextBox.TabIndex = 11;
            // 
            // sumTextBox
            // 
            this.sumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_ProjectsBindingSource, "Sum", true));
            this.sumTextBox.Location = new System.Drawing.Point(119, 116);
            this.sumTextBox.Name = "sumTextBox";
            this.sumTextBox.Size = new System.Drawing.Size(86, 19);
            this.sumTextBox.TabIndex = 13;
            // 
            // numTextBox
            // 
            this.numTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_ProjectsBindingSource, "Num", true));
            this.numTextBox.Location = new System.Drawing.Point(119, 40);
            this.numTextBox.Name = "numTextBox";
            this.numTextBox.Size = new System.Drawing.Size(60, 19);
            this.numTextBox.TabIndex = 3;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_TEO);
            this.tabControl.Controls.Add(this.tabPage_ProductionStages);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(741, 409);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage_TEO
            // 
            this.tabPage_TEO.Controls.Add(this.table_TEOMaterialsDataGridView);
            this.tabPage_TEO.Location = new System.Drawing.Point(4, 22);
            this.tabPage_TEO.Name = "tabPage_TEO";
            this.tabPage_TEO.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_TEO.Size = new System.Drawing.Size(733, 383);
            this.tabPage_TEO.TabIndex = 0;
            this.tabPage_TEO.Text = "Список материалов и работ";
            this.tabPage_TEO.UseVisualStyleBackColor = true;
            // 
            // table_TEOMaterialsDataGridView
            // 
            this.table_TEOMaterialsDataGridView.AutoGenerateColumns = false;
            this.table_TEOMaterialsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.table_TEOMaterialsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_TEOMaterialsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TEOMaterialID,
            this.TEOMaterialProjectID,
            this.TEOMaterialMaterialID,
            this.TEOMaterialSupplierID,
            this.TEOMaterialPrice,
            this.TEOMaterialCount});
            this.table_TEOMaterialsDataGridView.DataSource = this.table_TEOMaterialsBindingSource;
            this.table_TEOMaterialsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_TEOMaterialsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.table_TEOMaterialsDataGridView.MultiSelect = false;
            this.table_TEOMaterialsDataGridView.Name = "table_TEOMaterialsDataGridView";
            this.table_TEOMaterialsDataGridView.Size = new System.Drawing.Size(727, 377);
            this.table_TEOMaterialsDataGridView.TabIndex = 0;
            this.table_TEOMaterialsDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.table_TEOMaterialsDataGridView_CellBeginEdit);
            this.table_TEOMaterialsDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_TEOMaterialsDataGridView_CellValueChanged);
            this.table_TEOMaterialsDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.table_TEOMaterialsDataGridView_DefaultValuesNeeded);
            // 
            // TEOMaterialID
            // 
            this.TEOMaterialID.DataPropertyName = "id";
            this.TEOMaterialID.HeaderText = "id";
            this.TEOMaterialID.Name = "TEOMaterialID";
            this.TEOMaterialID.Visible = false;
            // 
            // TEOMaterialProjectID
            // 
            this.TEOMaterialProjectID.DataPropertyName = "ProjectID";
            this.TEOMaterialProjectID.DataSource = this.tableProjectsBindingSource;
            this.TEOMaterialProjectID.DisplayMember = "Name";
            this.TEOMaterialProjectID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.TEOMaterialProjectID.HeaderText = "Заказ";
            this.TEOMaterialProjectID.Name = "TEOMaterialProjectID";
            this.TEOMaterialProjectID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TEOMaterialProjectID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TEOMaterialProjectID.ValueMember = "id";
            this.TEOMaterialProjectID.Visible = false;
            // 
            // tableProjectsBindingSource
            // 
            this.tableProjectsBindingSource.DataMember = "Table_Projects";
            this.tableProjectsBindingSource.DataSource = this.cA_DB_DataSet;
            // 
            // TEOMaterialMaterialID
            // 
            this.TEOMaterialMaterialID.DataPropertyName = "MaterialID";
            this.TEOMaterialMaterialID.DataSource = this.tableMaterialsBindingSource;
            this.TEOMaterialMaterialID.DisplayMember = "Name";
            this.TEOMaterialMaterialID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.TEOMaterialMaterialID.HeaderText = "Материал";
            this.TEOMaterialMaterialID.Name = "TEOMaterialMaterialID";
            this.TEOMaterialMaterialID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TEOMaterialMaterialID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TEOMaterialMaterialID.ValueMember = "id";
            this.TEOMaterialMaterialID.Width = 82;
            // 
            // tableMaterialsBindingSource
            // 
            this.tableMaterialsBindingSource.DataMember = "Table_Materials";
            this.tableMaterialsBindingSource.DataSource = this.cA_DB_DataSet;
            // 
            // TEOMaterialSupplierID
            // 
            this.TEOMaterialSupplierID.DataPropertyName = "SupplierID";
            this.TEOMaterialSupplierID.DataSource = this.tableCompaniesBindingSource;
            this.TEOMaterialSupplierID.DisplayMember = "Name";
            this.TEOMaterialSupplierID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.TEOMaterialSupplierID.HeaderText = "Поставщик";
            this.TEOMaterialSupplierID.Name = "TEOMaterialSupplierID";
            this.TEOMaterialSupplierID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TEOMaterialSupplierID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TEOMaterialSupplierID.ValueMember = "id";
            this.TEOMaterialSupplierID.Width = 90;
            // 
            // tableCompaniesBindingSource
            // 
            this.tableCompaniesBindingSource.DataMember = "Table_Companies";
            this.tableCompaniesBindingSource.DataSource = this.cA_DB_DataSet;
            // 
            // TEOMaterialPrice
            // 
            this.TEOMaterialPrice.DataPropertyName = "Price";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.TEOMaterialPrice.DefaultCellStyle = dataGridViewCellStyle5;
            this.TEOMaterialPrice.HeaderText = "Цена";
            this.TEOMaterialPrice.Name = "TEOMaterialPrice";
            this.TEOMaterialPrice.Width = 58;
            // 
            // TEOMaterialCount
            // 
            this.TEOMaterialCount.DataPropertyName = "Count";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.TEOMaterialCount.DefaultCellStyle = dataGridViewCellStyle6;
            this.TEOMaterialCount.HeaderText = "Кол-во";
            this.TEOMaterialCount.Name = "TEOMaterialCount";
            this.TEOMaterialCount.Width = 66;
            // 
            // table_TEOMaterialsBindingSource
            // 
            this.table_TEOMaterialsBindingSource.DataMember = "FK_Table_TEOMaterials_Table_Projects";
            this.table_TEOMaterialsBindingSource.DataSource = this.table_ProjectsBindingSource;
            // 
            // tabPage_ProductionStages
            // 
            this.tabPage_ProductionStages.Controls.Add(this.table_ProductionStagesDataGridView);
            this.tabPage_ProductionStages.Location = new System.Drawing.Point(4, 22);
            this.tabPage_ProductionStages.Name = "tabPage_ProductionStages";
            this.tabPage_ProductionStages.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ProductionStages.Size = new System.Drawing.Size(733, 383);
            this.tabPage_ProductionStages.TabIndex = 1;
            this.tabPage_ProductionStages.Text = "Этапы производства";
            this.tabPage_ProductionStages.UseVisualStyleBackColor = true;
            // 
            // table_ProductionStagesDataGridView
            // 
            this.table_ProductionStagesDataGridView.AutoGenerateColumns = false;
            this.table_ProductionStagesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.table_ProductionStagesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_ProductionStagesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductionStageID,
            this.ProductionStageProjectID,
            this.ProductionStageName,
            this.ProductionStageDate,
            this.ProductionStageDuration});
            this.table_ProductionStagesDataGridView.DataSource = this.table_ProductionStagesBindingSource;
            this.table_ProductionStagesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_ProductionStagesDataGridView.Location = new System.Drawing.Point(3, 3);
            this.table_ProductionStagesDataGridView.MultiSelect = false;
            this.table_ProductionStagesDataGridView.Name = "table_ProductionStagesDataGridView";
            this.table_ProductionStagesDataGridView.Size = new System.Drawing.Size(727, 377);
            this.table_ProductionStagesDataGridView.TabIndex = 18;
            // 
            // ProductionStageID
            // 
            this.ProductionStageID.DataPropertyName = "id";
            this.ProductionStageID.HeaderText = "id";
            this.ProductionStageID.Name = "ProductionStageID";
            this.ProductionStageID.Visible = false;
            // 
            // ProductionStageProjectID
            // 
            this.ProductionStageProjectID.DataPropertyName = "ProjectID";
            this.ProductionStageProjectID.DataSource = this.tableProjectsBindingSource1;
            this.ProductionStageProjectID.DisplayMember = "Name";
            this.ProductionStageProjectID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ProductionStageProjectID.HeaderText = "Заказ";
            this.ProductionStageProjectID.Name = "ProductionStageProjectID";
            this.ProductionStageProjectID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductionStageProjectID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ProductionStageProjectID.ValueMember = "id";
            this.ProductionStageProjectID.Width = 63;
            // 
            // tableProjectsBindingSource1
            // 
            this.tableProjectsBindingSource1.DataMember = "Table_Projects";
            this.tableProjectsBindingSource1.DataSource = this.cA_DB_DataSet;
            // 
            // ProductionStageName
            // 
            this.ProductionStageName.DataPropertyName = "Name";
            this.ProductionStageName.HeaderText = "Этап";
            this.ProductionStageName.Name = "ProductionStageName";
            this.ProductionStageName.Width = 56;
            // 
            // ProductionStageDate
            // 
            this.ProductionStageDate.DataPropertyName = "Date";
            this.ProductionStageDate.HeaderText = "Дата начала";
            this.ProductionStageDate.Name = "ProductionStageDate";
            this.ProductionStageDate.Width = 96;
            // 
            // ProductionStageDuration
            // 
            this.ProductionStageDuration.DataPropertyName = "Duration";
            this.ProductionStageDuration.HeaderText = "Длительность";
            this.ProductionStageDuration.Name = "ProductionStageDuration";
            this.ProductionStageDuration.Width = 105;
            // 
            // table_ProductionStagesBindingSource
            // 
            this.table_ProductionStagesBindingSource.DataMember = "FK_Table_ProductionStages_Table_Projects";
            this.table_ProductionStagesBindingSource.DataSource = this.table_ProjectsBindingSource;
            // 
            // table_ProjectsTableAdapter
            // 
            this.table_ProjectsTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Table_MeasureUnitsTableAdapter = null;
            this.tableAdapterManager.Table_MoneyFlowTableAdapter = null;
            this.tableAdapterManager.Table_ProductionStagesTableAdapter = this.table_ProductionStagesTableAdapter;
            this.tableAdapterManager.Table_ProjectsTableAdapter = this.table_ProjectsTableAdapter;
            this.tableAdapterManager.Table_ProjectStatusesTableAdapter = null;
            this.tableAdapterManager.Table_SectionsTableAdapter = null;
            this.tableAdapterManager.Table_TEOMaterialsTableAdapter = this.table_TEOMaterialsTableAdapter;
            this.tableAdapterManager.Table_UsersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CA.CA_DB_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // table_ProductionStagesTableAdapter
            // 
            this.table_ProductionStagesTableAdapter.ClearBeforeFill = true;
            // 
            // table_TEOMaterialsTableAdapter
            // 
            this.table_TEOMaterialsTableAdapter.ClearBeforeFill = true;
            // 
            // table_MaterialsTableAdapter
            // 
            this.table_MaterialsTableAdapter.ClearBeforeFill = true;
            // 
            // table_CompaniesTableAdapter
            // 
            this.table_CompaniesTableAdapter.ClearBeforeFill = true;
            // 
            // table_ProjectStatusesTableAdapter
            // 
            this.table_ProjectStatusesTableAdapter.ClearBeforeFill = true;
            // 
            // button_Refresh
            // 
            this.button_Refresh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_Refresh.Location = new System.Drawing.Point(0, 591);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(215, 40);
            this.button_Refresh.TabIndex = 11;
            this.button_Refresh.Text = "Обновить";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // Form_ProjectCurrent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 635);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form_ProjectCurrent";
            this.Text = "Заказ";
            this.Load += new System.EventHandler(this.Form_ProjectCurrent_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_ProjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cA_DB_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableCompaniesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableProjectStatusesBindingSource)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage_TEO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_TEOMaterialsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableProjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableMaterialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableCompaniesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_TEOMaterialsBindingSource)).EndInit();
            this.tabPage_ProductionStages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_ProductionStagesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableProjectsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_ProductionStagesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private CA_DB_DataSet cA_DB_DataSet;
        private System.Windows.Forms.BindingSource table_ProjectsBindingSource;
        private CA_DB_DataSetTableAdapters.Table_ProjectsTableAdapter table_ProjectsTableAdapter;
        private CA_DB_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox numTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox companyIDTextBox;
        private System.Windows.Forms.TextBox marginTextBox;
        private System.Windows.Forms.TextBox sumTextBox;
        private System.Windows.Forms.TextBox projectStatusIDTextBox;
        private System.Windows.Forms.TextBox commentTextBox;
        private CA_DB_DataSetTableAdapters.Table_ProductionStagesTableAdapter table_ProductionStagesTableAdapter;
        private System.Windows.Forms.BindingSource table_ProductionStagesBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridView table_ProductionStagesDataGridView;
        private CA_DB_DataSetTableAdapters.Table_TEOMaterialsTableAdapter table_TEOMaterialsTableAdapter;
        private System.Windows.Forms.BindingSource table_TEOMaterialsBindingSource;
        private System.Windows.Forms.DataGridView table_TEOMaterialsDataGridView;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_TEO;
        private System.Windows.Forms.TabPage tabPage_ProductionStages;
        private System.Windows.Forms.BindingSource tableProjectsBindingSource;
        private System.Windows.Forms.BindingSource tableMaterialsBindingSource;
        private CA_DB_DataSetTableAdapters.Table_MaterialsTableAdapter table_MaterialsTableAdapter;
        private System.Windows.Forms.BindingSource tableCompaniesBindingSource;
        private CA_DB_DataSetTableAdapters.Table_CompaniesTableAdapter table_CompaniesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEOMaterialID;
        private System.Windows.Forms.DataGridViewComboBoxColumn TEOMaterialProjectID;
        private System.Windows.Forms.DataGridViewComboBoxColumn TEOMaterialMaterialID;
        private System.Windows.Forms.DataGridViewComboBoxColumn TEOMaterialSupplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEOMaterialPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEOMaterialCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductionStageID;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProductionStageProjectID;
        private System.Windows.Forms.BindingSource tableProjectsBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductionStageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductionStageDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductionStageDuration;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource tableCompaniesBindingSource1;
        private System.Windows.Forms.BindingSource tableProjectStatusesBindingSource;
        private CA_DB_DataSetTableAdapters.Table_ProjectStatusesTableAdapter table_ProjectStatusesTableAdapter;
        private System.Windows.Forms.Button button_Refresh;
    }
}