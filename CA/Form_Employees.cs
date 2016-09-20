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
        public override void BS_Fill()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_CompanyTypes". При необходимости она может быть перемещена или удалена.
            this.table_CompanyTypesTableAdapter.Fill(this.cA_DB_DataSet.Table_CompanyTypes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_Employees". При необходимости она может быть перемещена или удалена.
            this.table_EmployeesTableAdapter.Fill(this.cA_DB_DataSet.Table_Employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_Companies". При необходимости она может быть перемещена или удалена.
            this.table_CompaniesTableAdapter.Fill(this.cA_DB_DataSet.Table_Companies);
        }
        public override void BS_Save()
        {
            this.table_CompaniesBindingSource.EndEdit();
            this.table_CompaniesTableAdapter.Adapter.Update(cA_DB_DataSet);
            this.table_EmployeesBindingSource.EndEdit();
            this.table_EmployeesTableAdapter.Adapter.Update(cA_DB_DataSet);
        }
        private void table_EmployeesDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["EmployeeID"].Value = Guid.NewGuid();
        }
        private void table_EmployeesDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //добавить проверку корректности внесенных данных
            if (e.RowIndex == -1) return;
            if (e.RowIndex == (sender as DataGridView).RowCount - 1) return;
            BS_Save();
        }
        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            //BS_Delete(table_EmployeesDataGridView); ссылки в базе !!!
        }
        public Form_Employees()
        { InitializeComponent(); }
        /*private void table_CompaniesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.table_CompaniesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cA_DB_DataSet);
        }*/
        private void Form_Employees_Load(object sender, EventArgs e)
        {
            BS_Fill();
        }
        private void button_Refresh_Click(object sender, EventArgs e)
        {
            BS_Refresh(table_CompaniesDataGridView, table_EmployeesDataGridView);
        }
    }
}