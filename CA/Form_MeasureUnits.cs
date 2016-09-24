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
    public partial class Form_MeasureUnits : Form_BaseStyle
    {
        public override void BS_Fill()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_MeasureUnits". При необходимости она может быть перемещена или удалена.
            this.table_MeasureUnitsTableAdapter.Fill(this.cA_DB_DataSet.Table_MeasureUnits);
        }
        public override void BS_Save()
        {
            this.table_MeasureUnitsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cA_DB_DataSet);
        }
        private void table_MeasureUnitsDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["MeasureUnitID"].Value = Guid.NewGuid();
        }
        private void table_MeasureUnitsDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (e.RowIndex == (sender as DataGridView).RowCount - 1) return;
            BS_Save();
        }
        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            //BS_DeleteRow(table_MeasureUnitsDataGridView);// ссылки в базе !!!
        }
        public Form_MeasureUnits()
        { InitializeComponent(); }
        private void Form_MeasureUnits_Load(object sender, EventArgs e)
        {
            BS_Fill();
        }
    }
}
