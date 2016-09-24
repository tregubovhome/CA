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
        public override void BS_Fill()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_Companies". При необходимости она может быть перемещена или удалена.
            this.table_CompaniesTableAdapter.Fill(this.cA_DB_DataSet.Table_Companies);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_CompanyTypes". При необходимости она может быть перемещена или удалена.
            this.table_CompanyTypesTableAdapter.Fill(this.cA_DB_DataSet.Table_CompanyTypes);
        }
        public override void BS_Save()
        {
            this.table_CompaniesBindingSource.EndEdit();
            this.table_CompaniesTableAdapter.Adapter.Update(cA_DB_DataSet);
            this.table_CompanyTypesBindingSource.EndEdit();
            this.table_CompanyTypesTableAdapter.Adapter.Update(cA_DB_DataSet);
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
        private void table_CompaniesDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            BS_SpecialEdit(sender as DataGridView, e);
        }
        private void table_CompaniesDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //добавить проверку корректности внесенных данных
            if (e.RowIndex == -1) return;
            if (e.RowIndex == (sender as DataGridView).RowCount - 1) return;
            BS_Save();
        }
        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            //BS_DeleteRow(table_CompaniesDataGridView); ссылки в базе!!!
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
            BS_Refresh(table_CompanyTypesDataGridView, table_CompaniesDataGridView);
        }
    }
}