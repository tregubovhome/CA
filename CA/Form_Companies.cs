using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA
{
    public partial class Form_Companies : Form_BaseStyle
    {
        public override string BS_caption
        {
            set { BS_caption = value; }
            get { return "Организации"; }
        }
        public override void BS_Fill()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_Companies". При необходимости она может быть перемещена или удалена.
            this.table_CompaniesTableAdapter.Fill(this.cA_DB_DataSet.Table_Companies);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_CompanyTypes". При необходимости она может быть перемещена или удалена.
            this.table_CompanyTypesTableAdapter.Fill(this.cA_DB_DataSet.Table_CompanyTypes);
        }
        public override void BS_LoadData()
        {
            this.Text = BS_caption;
            Guid _currMasterID = (Guid)table_CompanyTypesDataGridView["CompanyTypeID", table_CompanyTypesDataGridView.CurrentRow.Index].Value;
            Guid _currSlaveID = (Guid)table_CompaniesDataGridView["CompanyID", table_CompaniesDataGridView.CurrentRow.Index].Value;
            BS_Fill();
            if (_currMasterID != Guid.Empty && _currSlaveID != Guid.Empty)
            {
                this.table_CompanyTypesBindingSource.Position = this.table_CompanyTypesBindingSource.Find("id", _currMasterID);
                DataGridViewRow row = table_CompaniesDataGridView.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.IsNewRow.Equals(false))
                    .Where(r => r.Cells["CompanyID"].Value.ToString().Equals(_currSlaveID.ToString()))
                    .First();
                this.table_CompaniesBindingSource.Position = row.Index;
            }
        }
        private void table_CompaniesDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["CompanyID"].Value = Guid.NewGuid();
            DataTable dt = table_CompaniesTableAdapter.GetData();
            int dtmax = dt.AsEnumerable()
                .Select(r => r.Field<int>("Num"))
                .Distinct()
                .Max();
            e.Row.Cells["Num"].Value = dtmax + 1;
            e.Row.Cells["Date"].Value = DateTime.Today;
        }
        private void table_CompaniesDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            button_Save_Click(sender, e);
        }
        private void table_CompaniesDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            BS_DataChanged();
        }
        public Form_Companies()
        { InitializeComponent(); }
        /*private void table_CompanyTypesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.table_CompanyTypesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cA_DB_DataSet);
        }*/
        private void Form_Companies_Load(object sender, EventArgs e)
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
            this.table_CompanyTypesBindingSource.EndEdit();
            this.table_CompanyTypesTableAdapter.Adapter.Update(cA_DB_DataSet);
            this.Text = BS_caption;
        }
        private void button_SaveAndClose_Click(object sender, EventArgs e)
        {
            button_Save_Click(sender, e);
            Close();
        }
    }
}