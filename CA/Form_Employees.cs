using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA
{
    public partial class Form_Employees : Form_BaseStyle
    {
        private Guid CurrentID = Guid.Empty;
        public Form_Employees()
        {
            InitializeComponent();
        }
        private void table_EmployeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            table_EmployeesBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(cA_DB_DataSet);
        }
        private void Form_Employees_Load(object sender, EventArgs e)
        {   // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_Employees". При необходимости она может быть перемещена или удалена.
            table_EmployeesTableAdapter.Fill(cA_DB_DataSet.Table_Employees);
        }
        private void button_CreateNew_Click(object sender, EventArgs e)
        {
            CurrentID = Guid.NewGuid();
            Form_Employee form_Employee = new Form_Employee(true, CurrentID);
            form_Employee.ShowDialog();
            table_EmployeesTableAdapter.Fill(cA_DB_DataSet.Table_Employees);
            table_EmployeesBindingSource.Position = table_EmployeesBindingSource.Find("id", CurrentID);
        }
        private void button_CloneCurrent_Click(object sender, EventArgs e)
        {
            CurrentID = Guid.NewGuid();
            Form_Employee form_Employee = new Form_Employee(true, 
                CurrentID,
                (string)table_EmployeesDataGridView["dataGridViewTextBoxColumn2", table_EmployeesDataGridView.CurrentRow.Index].Value,
                (string)table_EmployeesDataGridView["dataGridViewTextBoxColumn3", table_EmployeesDataGridView.CurrentRow.Index].Value,
                (string)table_EmployeesDataGridView["dataGridViewTextBoxColumn4", table_EmployeesDataGridView.CurrentRow.Index].Value
                );
            form_Employee.ShowDialog();
            table_EmployeesTableAdapter.Fill(cA_DB_DataSet.Table_Employees);
            table_EmployeesBindingSource.Position = table_EmployeesBindingSource.Find("id", CurrentID);
        }
        private void table_EmployeesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CurrentID = (Guid)table_EmployeesDataGridView["dataGridViewTextBoxColumn1", e.RowIndex].Value;
            Form_Employee form_Employee = new Form_Employee(CurrentID);
            form_Employee.ShowDialog();
            table_EmployeesTableAdapter.Fill(cA_DB_DataSet.Table_Employees);
            table_EmployeesBindingSource.Position = table_EmployeesBindingSource.Find("id", CurrentID);
        }
        private void button_EditCurrent_Click(object sender, EventArgs e)
        {
            CurrentID = (Guid)table_EmployeesDataGridView["dataGridViewTextBoxColumn1", table_EmployeesDataGridView.CurrentRow.Index].Value;
            Form_Employee form_Employee = new Form_Employee(CurrentID);
            form_Employee.ShowDialog();
            table_EmployeesTableAdapter.Fill(cA_DB_DataSet.Table_Employees);
            table_EmployeesBindingSource.Position = table_EmployeesBindingSource.Find("id", CurrentID);
        }
        private void button_DeleteCurrent_Click(object sender, EventArgs e)
        {
            CurrentID = (Guid)table_EmployeesDataGridView["dataGridViewTextBoxColumn1", table_EmployeesDataGridView.CurrentRow.Index].Value;
            int NewPosition = table_EmployeesBindingSource.Find("id", CurrentID) - 1;
            if (NewPosition < 0)
                NewPosition = 0;
            table_EmployeesTableAdapter.Delete(
                CurrentID,
                (string)table_EmployeesDataGridView["dataGridViewTextBoxColumn2", table_EmployeesDataGridView.CurrentRow.Index].Value,
                (string)table_EmployeesDataGridView["dataGridViewTextBoxColumn3", table_EmployeesDataGridView.CurrentRow.Index].Value,
                (string)table_EmployeesDataGridView["dataGridViewTextBoxColumn4", table_EmployeesDataGridView.CurrentRow.Index].Value
                );
            table_EmployeesTableAdapter.Fill(cA_DB_DataSet.Table_Employees);
            table_EmployeesBindingSource.Position = NewPosition;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CurrentID = (Guid)table_EmployeesDataGridView["dataGridViewTextBoxColumn1", table_EmployeesDataGridView.CurrentRow.Index].Value;
            table_EmployeesTableAdapter.Fill(cA_DB_DataSet.Table_Employees);
            table_EmployeesBindingSource.Position = table_EmployeesBindingSource.Find("id", CurrentID);
        }
        /*private void table_EmployeesDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            //NewRecordRow = e.Row.Index;
        }
        private int NewRecordRow;
        private void table_EmployeesDataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (NewRecordRow == e.RowIndex && table_EmployeesDataGridView["dataGridViewTextBoxColumn1", e.RowIndex].Value.ToString() == "" &&
                (table_EmployeesDataGridView["dataGridViewTextBoxColumn2", e.RowIndex].Value.ToString() != "" ||
                 table_EmployeesDataGridView["dataGridViewTextBoxColumn3", e.RowIndex].Value.ToString() != "" ||
                 table_EmployeesDataGridView["dataGridViewTextBoxColumn4", e.RowIndex].Value.ToString() != ""))
            {
                table_EmployeesDataGridView["dataGridViewTextBoxColumn1", e.RowIndex].Value = Guid.NewGuid();
            }
        }*/
    }
}