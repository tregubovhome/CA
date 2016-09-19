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
    public partial class Form_MoneyFlow : Form_BaseStyle
    {
        public override string BS_caption
        {
            set { BS_caption = value; }
            get { return "Расходы и поступления"; }
        }
        public override void BS_Fill()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_Materials". При необходимости она может быть перемещена или удалена.
            this.table_MaterialsTableAdapter.Fill(this.cA_DB_DataSet.Table_Materials);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_Employees". При необходимости она может быть перемещена или удалена.
            this.table_EmployeesTableAdapter.Fill(this.cA_DB_DataSet.Table_Employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_MoneyFlow". При необходимости она может быть перемещена или удалена.
            this.table_MoneyFlowTableAdapter.Fill(this.cA_DB_DataSet.Table_MoneyFlow);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_Projects". При необходимости она может быть перемещена или удалена.
            this.table_ProjectsTableAdapter.Fill(this.cA_DB_DataSet.Table_Projects);
        }
        public override void BS_LoadData()
        {
            this.Text = BS_caption;
            Guid _currMasterID = (Guid)dataGridView1["ProjectID", dataGridView1.CurrentRow.Index].Value;
            Guid _currSlaveID = (Guid)table_MoneyFlowDataGridView["MoneyFlowID", table_MoneyFlowDataGridView.CurrentRow.Index].Value;
            BS_Fill();
            if (_currMasterID != Guid.Empty && _currSlaveID != Guid.Empty)
            {
                this.tableProjectsBindingSource.Position = this.tableProjectsBindingSource.Find("id", _currMasterID);
                DataGridViewRow row = table_MoneyFlowDataGridView.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.IsNewRow.Equals(false))
                    .Where(r => r.Cells["MoneyFlowID"].Value.ToString().Equals(_currSlaveID.ToString()))
                    .First();
                this.table_MoneyFlowBindingSource.Position = row.Index;
            }
        }
        private void table_MoneyFlowDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["MoneyFlowID"].Value = Guid.NewGuid();
            e.Row.Cells["Date"].Value = DateTime.Today;
            e.Row.Cells["IsCash"].Value = true;
        }
        private void table_MoneyFlowDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            BS_DataChanged();
        }
        public Form_MoneyFlow()
        { InitializeComponent(); }
        private void Form_MoneyFlow_Load(object sender, EventArgs e)
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
            this.table_MoneyFlowBindingSource.EndEdit();
            this.table_MoneyFlowTableAdapter.Adapter.Update(cA_DB_DataSet);
            this.tableProjectsBindingSource.EndEdit();
            this.table_ProjectsTableAdapter.Adapter.Update(cA_DB_DataSet);
            this.Text = BS_caption;
        }
        private void button_SaveAndClose_Click(object sender, EventArgs e)
        {
            button_Save_Click(sender, e);
            Close();
        }
    }
}
