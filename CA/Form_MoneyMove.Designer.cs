namespace CA
{
    partial class Form_MoneyMove
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
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label sumLabel;
            System.Windows.Forms.Label isCashLabel;
            System.Windows.Forms.Label expensesTypeLabel;
            System.Windows.Forms.Label projectLabel;
            System.Windows.Forms.Label employeeLabel;
            System.Windows.Forms.Label descriptionLabel;
            this.cA_DB_DataSet = new CA.CA_DB_DataSet();
            this.table_MoneyMovesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_MoneyMovesTableAdapter = new CA.CA_DB_DataSetTableAdapters.Table_MoneyMovesTableAdapter();
            this.tableAdapterManager = new CA.CA_DB_DataSetTableAdapters.TableAdapterManager();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sumTextBox = new System.Windows.Forms.TextBox();
            this.isCashCheckBox = new System.Windows.Forms.CheckBox();
            this.expensesTypeComboBox = new System.Windows.Forms.ComboBox();
            this.tableExpensesTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectComboBox = new System.Windows.Forms.ComboBox();
            this.tableProjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeComboBox = new System.Windows.Forms.ComboBox();
            this.tableEmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.button_SaveCurrent = new System.Windows.Forms.Button();
            this.button_SaveCurrentAndClose = new System.Windows.Forms.Button();
            this.table_ExpensesTypesTableAdapter = new CA.CA_DB_DataSetTableAdapters.Table_ExpensesTypesTableAdapter();
            this.table_EmployeesTableAdapter = new CA.CA_DB_DataSetTableAdapters.Table_EmployeesTableAdapter();
            this.table_ProjectsTableAdapter = new CA.CA_DB_DataSetTableAdapters.Table_ProjectsTableAdapter();
            idLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            sumLabel = new System.Windows.Forms.Label();
            isCashLabel = new System.Windows.Forms.Label();
            expensesTypeLabel = new System.Windows.Forms.Label();
            projectLabel = new System.Windows.Forms.Label();
            employeeLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cA_DB_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_MoneyMovesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableExpensesTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableProjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableEmployeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(12, 13);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(12, 42);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 3;
            dateLabel.Text = "Date:";
            // 
            // sumLabel
            // 
            sumLabel.AutoSize = true;
            sumLabel.Location = new System.Drawing.Point(12, 69);
            sumLabel.Name = "sumLabel";
            sumLabel.Size = new System.Drawing.Size(31, 13);
            sumLabel.TabIndex = 5;
            sumLabel.Text = "Sum:";
            // 
            // isCashLabel
            // 
            isCashLabel.AutoSize = true;
            isCashLabel.Location = new System.Drawing.Point(12, 99);
            isCashLabel.Name = "isCashLabel";
            isCashLabel.Size = new System.Drawing.Size(45, 13);
            isCashLabel.TabIndex = 7;
            isCashLabel.Text = "Is Cash:";
            // 
            // expensesTypeLabel
            // 
            expensesTypeLabel.AutoSize = true;
            expensesTypeLabel.Location = new System.Drawing.Point(12, 127);
            expensesTypeLabel.Name = "expensesTypeLabel";
            expensesTypeLabel.Size = new System.Drawing.Size(83, 13);
            expensesTypeLabel.TabIndex = 9;
            expensesTypeLabel.Text = "Expenses Type:";
            // 
            // projectLabel
            // 
            projectLabel.AutoSize = true;
            projectLabel.Location = new System.Drawing.Point(12, 158);
            projectLabel.Name = "projectLabel";
            projectLabel.Size = new System.Drawing.Size(43, 13);
            projectLabel.TabIndex = 11;
            projectLabel.Text = "Project:";
            // 
            // employeeLabel
            // 
            employeeLabel.AutoSize = true;
            employeeLabel.Location = new System.Drawing.Point(12, 189);
            employeeLabel.Name = "employeeLabel";
            employeeLabel.Size = new System.Drawing.Size(56, 13);
            employeeLabel.TabIndex = 13;
            employeeLabel.Text = "Employee:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(12, 220);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 15;
            descriptionLabel.Text = "Description:";
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
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_MoneyMovesBindingSource, "id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(127, 10);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 19);
            this.idTextBox.TabIndex = 2;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.table_MoneyMovesBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(127, 38);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 19);
            this.dateDateTimePicker.TabIndex = 4;
            // 
            // sumTextBox
            // 
            this.sumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_MoneyMovesBindingSource, "Sum", true));
            this.sumTextBox.Location = new System.Drawing.Point(127, 66);
            this.sumTextBox.Name = "sumTextBox";
            this.sumTextBox.Size = new System.Drawing.Size(200, 19);
            this.sumTextBox.TabIndex = 6;
            // 
            // isCashCheckBox
            // 
            this.isCashCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.table_MoneyMovesBindingSource, "IsCash", true));
            this.isCashCheckBox.Location = new System.Drawing.Point(127, 94);
            this.isCashCheckBox.Name = "isCashCheckBox";
            this.isCashCheckBox.Size = new System.Drawing.Size(200, 24);
            this.isCashCheckBox.TabIndex = 8;
            this.isCashCheckBox.Text = "checkBox1";
            this.isCashCheckBox.UseVisualStyleBackColor = true;
            // 
            // expensesTypeComboBox
            // 
            this.expensesTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_MoneyMovesBindingSource, "ExpensesType", true));
            this.expensesTypeComboBox.DataSource = this.tableExpensesTypesBindingSource;
            this.expensesTypeComboBox.DisplayMember = "Type";
            this.expensesTypeComboBox.FormattingEnabled = true;
            this.expensesTypeComboBox.Location = new System.Drawing.Point(127, 124);
            this.expensesTypeComboBox.Name = "expensesTypeComboBox";
            this.expensesTypeComboBox.Size = new System.Drawing.Size(200, 21);
            this.expensesTypeComboBox.TabIndex = 10;
            this.expensesTypeComboBox.ValueMember = "id";
            // 
            // tableExpensesTypesBindingSource
            // 
            this.tableExpensesTypesBindingSource.DataMember = "Table_ExpensesTypes";
            this.tableExpensesTypesBindingSource.DataSource = this.cA_DB_DataSet;
            // 
            // projectComboBox
            // 
            this.projectComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_MoneyMovesBindingSource, "Project", true));
            this.projectComboBox.DataSource = this.tableProjectsBindingSource;
            this.projectComboBox.DisplayMember = "Project";
            this.projectComboBox.FormattingEnabled = true;
            this.projectComboBox.Location = new System.Drawing.Point(127, 155);
            this.projectComboBox.Name = "projectComboBox";
            this.projectComboBox.Size = new System.Drawing.Size(200, 21);
            this.projectComboBox.TabIndex = 12;
            this.projectComboBox.ValueMember = "id";
            // 
            // tableProjectsBindingSource
            // 
            this.tableProjectsBindingSource.DataMember = "Table_Projects";
            this.tableProjectsBindingSource.DataSource = this.cA_DB_DataSet;
            // 
            // employeeComboBox
            // 
            this.employeeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.table_MoneyMovesBindingSource, "Employee", true));
            this.employeeComboBox.DataSource = this.tableEmployeesBindingSource;
            this.employeeComboBox.DisplayMember = "LastName";
            this.employeeComboBox.FormattingEnabled = true;
            this.employeeComboBox.Location = new System.Drawing.Point(127, 186);
            this.employeeComboBox.Name = "employeeComboBox";
            this.employeeComboBox.Size = new System.Drawing.Size(200, 21);
            this.employeeComboBox.TabIndex = 14;
            this.employeeComboBox.ValueMember = "id";
            // 
            // tableEmployeesBindingSource
            // 
            this.tableEmployeesBindingSource.DataMember = "Table_Employees";
            this.tableEmployeesBindingSource.DataSource = this.cA_DB_DataSet;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_MoneyMovesBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(127, 217);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 19);
            this.descriptionTextBox.TabIndex = 16;
            // 
            // button_SaveCurrent
            // 
            this.button_SaveCurrent.Location = new System.Drawing.Point(237, 245);
            this.button_SaveCurrent.Name = "button_SaveCurrent";
            this.button_SaveCurrent.Size = new System.Drawing.Size(90, 38);
            this.button_SaveCurrent.TabIndex = 17;
            this.button_SaveCurrent.Text = "Сохранить";
            this.button_SaveCurrent.UseVisualStyleBackColor = true;
            this.button_SaveCurrent.Click += new System.EventHandler(this.button_SaveCurrent_Click);
            // 
            // button_SaveCurrentAndClose
            // 
            this.button_SaveCurrentAndClose.Location = new System.Drawing.Point(71, 245);
            this.button_SaveCurrentAndClose.Name = "button_SaveCurrentAndClose";
            this.button_SaveCurrentAndClose.Size = new System.Drawing.Size(160, 38);
            this.button_SaveCurrentAndClose.TabIndex = 17;
            this.button_SaveCurrentAndClose.Text = "Сохранить и закрыть";
            this.button_SaveCurrentAndClose.UseVisualStyleBackColor = true;
            this.button_SaveCurrentAndClose.Click += new System.EventHandler(this.button_SaveCurrentAndClose_Click);
            // 
            // table_ExpensesTypesTableAdapter
            // 
            this.table_ExpensesTypesTableAdapter.ClearBeforeFill = true;
            // 
            // table_EmployeesTableAdapter
            // 
            this.table_EmployeesTableAdapter.ClearBeforeFill = true;
            // 
            // table_ProjectsTableAdapter
            // 
            this.table_ProjectsTableAdapter.ClearBeforeFill = true;
            // 
            // Form_MoneyMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 290);
            this.Controls.Add(this.button_SaveCurrentAndClose);
            this.Controls.Add(this.button_SaveCurrent);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(sumLabel);
            this.Controls.Add(this.sumTextBox);
            this.Controls.Add(isCashLabel);
            this.Controls.Add(this.isCashCheckBox);
            this.Controls.Add(expensesTypeLabel);
            this.Controls.Add(this.expensesTypeComboBox);
            this.Controls.Add(projectLabel);
            this.Controls.Add(this.projectComboBox);
            this.Controls.Add(employeeLabel);
            this.Controls.Add(this.employeeComboBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Name = "Form_MoneyMove";
            this.Text = "Form_MoneyMove";
            this.Load += new System.EventHandler(this.Form_MoneyMove_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cA_DB_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_MoneyMovesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableExpensesTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableProjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableEmployeesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CA_DB_DataSet cA_DB_DataSet;
        private System.Windows.Forms.BindingSource table_MoneyMovesBindingSource;
        private CA_DB_DataSetTableAdapters.Table_MoneyMovesTableAdapter table_MoneyMovesTableAdapter;
        private CA_DB_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox sumTextBox;
        private System.Windows.Forms.CheckBox isCashCheckBox;
        private System.Windows.Forms.ComboBox expensesTypeComboBox;
        private System.Windows.Forms.ComboBox projectComboBox;
        private System.Windows.Forms.ComboBox employeeComboBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button button_SaveCurrent;
        private System.Windows.Forms.Button button_SaveCurrentAndClose;
        private System.Windows.Forms.BindingSource tableExpensesTypesBindingSource;
        private CA_DB_DataSetTableAdapters.Table_ExpensesTypesTableAdapter table_ExpensesTypesTableAdapter;
        private System.Windows.Forms.BindingSource tableEmployeesBindingSource;
        private CA_DB_DataSetTableAdapters.Table_EmployeesTableAdapter table_EmployeesTableAdapter;
        private System.Windows.Forms.BindingSource tableProjectsBindingSource;
        private CA_DB_DataSetTableAdapters.Table_ProjectsTableAdapter table_ProjectsTableAdapter;

    }
}