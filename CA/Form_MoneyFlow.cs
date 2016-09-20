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
        public override void BS_Save()
        {
            this.table_MoneyFlowBindingSource.EndEdit();
            this.table_MoneyFlowTableAdapter.Adapter.Update(cA_DB_DataSet);
            this.tableProjectsBindingSource.EndEdit();
            this.table_ProjectsTableAdapter.Adapter.Update(cA_DB_DataSet);
        }
        private void table_MoneyFlowDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["MoneyFlowID"].Value = Guid.NewGuid();
            e.Row.Cells["Date"].Value = DateTime.Today;
            e.Row.Cells["IsCash"].Value = true;
        }
        //private bool IsLoaded = false;
        private void table_MoneyFlowDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //добавить проверку корректности внесенных данных
            if (e.RowIndex == -1) return;
            if (e.RowIndex == (sender as DataGridView).RowCount - 1) return;
            //if (!IsLoaded) return;
            BS_Save();
        }
        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            BS_DeleteRow(table_MoneyFlowDataGridView);
        }
        public Form_MoneyFlow()
        { InitializeComponent(); }
        private void Form_MoneyFlow_Load(object sender, EventArgs e)
        {
            BS_Fill();
        }
        private void button_Refresh_Click(object sender, EventArgs e)
        {
            BS_Refresh(table_ProjectsDataGridView, table_MoneyFlowDataGridView);
        }
        private void Form_MoneyFlow_Shown(object sender, EventArgs e)
        {
            //IsLoaded = true;
        }
    }
}
