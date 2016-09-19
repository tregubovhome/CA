namespace CA
{
    partial class Form_Project : Form_BaseStyle
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
            this.cA_DB_DataSet = new CA.CA_DB_DataSet();
            this.tableMoneyMovesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_MoneyMovesTableAdapter = new CA.CA_DB_DataSetTableAdapters.Table_MoneyMovesTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cA_DB_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableMoneyMovesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cA_DB_DataSet
            // 
            this.cA_DB_DataSet.DataSetName = "CA_DB_DataSet";
            this.cA_DB_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableMoneyMovesBindingSource
            // 
            this.tableMoneyMovesBindingSource.DataMember = "Table_MoneyMoves";
            this.tableMoneyMovesBindingSource.DataSource = this.cA_DB_DataSet;
            // 
            // table_MoneyMovesTableAdapter
            // 
            this.table_MoneyMovesTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(824, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 792);
            this.Controls.Add(this.button1);
            this.Name = "Form_Project";
            this.Text = "Form_Project";
            this.Load += new System.EventHandler(this.Form_Project_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cA_DB_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableMoneyMovesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CA_DB_DataSet cA_DB_DataSet;
        private System.Windows.Forms.BindingSource tableMoneyMovesBindingSource;
        private CA_DB_DataSetTableAdapters.Table_MoneyMovesTableAdapter table_MoneyMovesTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}