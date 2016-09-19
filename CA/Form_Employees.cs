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
        public override string BS_caption
        {
            set { BS_caption = value; }
            get { return "Сотрудники"; }
        }
        public override void BS_Fill()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_CompanyTypes". При необходимости она может быть перемещена или удалена.
            this.table_CompanyTypesTableAdapter.Fill(this.cA_DB_DataSet.Table_CompanyTypes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_Employees". При необходимости она может быть перемещена или удалена.
            this.table_EmployeesTableAdapter.Fill(this.cA_DB_DataSet.Table_Employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_Companies". При необходимости она может быть перемещена или удалена.
            this.table_CompaniesTableAdapter.Fill(this.cA_DB_DataSet.Table_Companies);
        }
        public override void BS_LoadData()
        {
            this.Text = BS_caption;
            Guid _currMasterID = (Guid)table_CompaniesDataGridView["CompanyID", table_CompaniesDataGridView.CurrentRow.Index].Value;
            Guid _currSlaveID = (Guid)table_EmployeesDataGridView["EmployeeID", table_EmployeesDataGridView.CurrentRow.Index].Value;
            BS_Fill();
            if (_currMasterID != Guid.Empty && _currSlaveID != Guid.Empty)
            {
                this.table_CompaniesBindingSource.Position = this.table_CompaniesBindingSource.Find("id", _currMasterID);
                DataGridViewRow row = table_CompaniesDataGridView.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.IsNewRow.Equals(false))
                    .Where(r => r.Cells["EmployeeID"].Value.ToString().Equals(_currSlaveID.ToString()))
                    .First();
                this.table_EmployeesBindingSource.Position = row.Index;
            }
        }
        private void table_EmployeesDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["EmployeeID"].Value = Guid.NewGuid();
        }
        private void table_EmployeesDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            BS_DataChanged();
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
            BS_Refresh();
        }
        private void button_Save_Click(object sender, EventArgs e)
        {
            Validate();
            this.table_CompaniesBindingSource.EndEdit();
            this.table_CompaniesTableAdapter.Adapter.Update(cA_DB_DataSet);
            this.table_EmployeesBindingSource.EndEdit();
            this.table_EmployeesTableAdapter.Adapter.Update(cA_DB_DataSet);
            this.Text = BS_caption;
        }
        private void button_SaveAndClose_Click(object sender, EventArgs e)
        {
            button_Save_Click(sender, e);
            Close();
        }
    }
}
