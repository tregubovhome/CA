namespace CA
{
    partial class Form_Employee : Form_BaseStyle
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
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label middleNameLabel;
            this.cA_DB_DataSet = new CA.CA_DB_DataSet();
            this.table_EmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_EmployeesTableAdapter = new CA.CA_DB_DataSetTableAdapters.Table_EmployeesTableAdapter();
            this.tableAdapterManager = new CA.CA_DB_DataSetTableAdapters.TableAdapterManager();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.button_SaveCurrent = new System.Windows.Forms.Button();
            this.button_SaveCurrentAndClose = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            middleNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cA_DB_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_EmployeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(12, 14);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(12, 42);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(80, 17);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(12, 70);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(80, 17);
            firstNameLabel.TabIndex = 5;
            firstNameLabel.Text = "First Name:";
            // 
            // middleNameLabel
            // 
            middleNameLabel.AutoSize = true;
            middleNameLabel.Location = new System.Drawing.Point(12, 98);
            middleNameLabel.Name = "middleNameLabel";
            middleNameLabel.Size = new System.Drawing.Size(94, 17);
            middleNameLabel.TabIndex = 7;
            middleNameLabel.Text = "Middle Name:";
            // 
            // cA_DB_DataSet
            // 
            this.cA_DB_DataSet.DataSetName = "CA_DB_DataSet";
            this.cA_DB_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_EmployeesBindingSource
            // 
            this.table_EmployeesBindingSource.DataMember = "Table_Employees";
            this.table_EmployeesBindingSource.DataSource = this.cA_DB_DataSet;
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
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_EmployeesBindingSource, "id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(112, 11);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(290, 22);
            this.idTextBox.TabIndex = 2;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_EmployeesBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(112, 39);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(290, 22);
            this.lastNameTextBox.TabIndex = 4;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_EmployeesBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(112, 67);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(290, 22);
            this.firstNameTextBox.TabIndex = 6;
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_EmployeesBindingSource, "MiddleName", true));
            this.middleNameTextBox.Location = new System.Drawing.Point(112, 95);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(290, 22);
            this.middleNameTextBox.TabIndex = 8;
            // 
            // button_SaveCurrent
            // 
            this.button_SaveCurrent.Location = new System.Drawing.Point(312, 123);
            this.button_SaveCurrent.Name = "button_SaveCurrent";
            this.button_SaveCurrent.Size = new System.Drawing.Size(90, 38);
            this.button_SaveCurrent.TabIndex = 9;
            this.button_SaveCurrent.Text = "Сохранить";
            this.button_SaveCurrent.UseVisualStyleBackColor = true;
            this.button_SaveCurrent.Click += new System.EventHandler(this.button_SaveCurrent_Click);
            // 
            // button_SaveCurrentAndClose
            // 
            this.button_SaveCurrentAndClose.Location = new System.Drawing.Point(147, 123);
            this.button_SaveCurrentAndClose.Name = "button_SaveCurrentAndClose";
            this.button_SaveCurrentAndClose.Size = new System.Drawing.Size(159, 38);
            this.button_SaveCurrentAndClose.TabIndex = 9;
            this.button_SaveCurrentAndClose.Text = "Сохранить и закрыть";
            this.button_SaveCurrentAndClose.UseVisualStyleBackColor = true;
            this.button_SaveCurrentAndClose.Click += new System.EventHandler(this.button_SaveCurrentAndClose_Click);
            // 
            // Form_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 168);
            this.Controls.Add(this.button_SaveCurrentAndClose);
            this.Controls.Add(this.button_SaveCurrent);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(middleNameLabel);
            this.Controls.Add(this.middleNameTextBox);
            this.Name = "Form_Employee";
            this.Text = "Form_Employee";
            this.Load += new System.EventHandler(this.Form_Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cA_DB_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_EmployeesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CA_DB_DataSet cA_DB_DataSet;
        private System.Windows.Forms.BindingSource table_EmployeesBindingSource;
        private CA_DB_DataSetTableAdapters.Table_EmployeesTableAdapter table_EmployeesTableAdapter;
        private CA_DB_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.Button button_SaveCurrent;
        private System.Windows.Forms.Button button_SaveCurrentAndClose;
    }
}