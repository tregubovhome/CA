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
    public partial class Form_Materials : Form_BaseStyle
    {
        public override string BS_caption
        {
            set { BS_caption = value; }
            get { return "Материалы"; }
        }
        public override void BS_Fill()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_MeasureUnits". При необходимости она может быть перемещена или удалена.
            this.table_MeasureUnitsTableAdapter.Fill(this.cA_DB_DataSet.Table_MeasureUnits);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_Sections". При необходимости она может быть перемещена или удалена.
            this.table_SectionsTableAdapter.Fill(this.cA_DB_DataSet.Table_Sections);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_MeasureUnits". При необходимости она может быть перемещена или удалена.
            this.table_MeasureUnitsTableAdapter.Fill(this.cA_DB_DataSet.Table_MeasureUnits);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_Sections". При необходимости она может быть перемещена или удалена.
            this.table_SectionsTableAdapter.Fill(this.cA_DB_DataSet.Table_Sections);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_Materials". При необходимости она может быть перемещена или удалена.
            this.table_MaterialsTableAdapter.Fill(this.cA_DB_DataSet.Table_Materials);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_MaterialGroups". При необходимости она может быть перемещена или удалена.
            this.table_MaterialGroupsTableAdapter.Fill(this.cA_DB_DataSet.Table_MaterialGroups);
        }
        public override void BS_LoadData()
        {
            this.Text = BS_caption;
            Guid _currMasterID = (Guid)table_MaterialGroupsDataGridView["GroupID", table_MaterialGroupsDataGridView.CurrentRow.Index].Value;
            Guid _currSlaveID = (Guid)table_MaterialsDataGridView["MaterialID", table_MaterialsDataGridView.CurrentRow.Index].Value;
            BS_Fill();
            if (_currMasterID != Guid.Empty && _currSlaveID != Guid.Empty)
            {
                this.table_MaterialGroupsBindingSource.Position = this.table_MaterialGroupsBindingSource.Find("id", _currMasterID);
                DataGridViewRow row = table_MaterialsDataGridView.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.IsNewRow.Equals(false))
                    .Where(r => r.Cells["MaterialID"].Value.ToString().Equals(_currSlaveID.ToString()))
                    .First();
                this.table_MaterialsBindingSource.Position = row.Index;
            }
        }
        private void table_MaterialGroupsDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["GroupID"].Value = Guid.NewGuid();
        }
        private void table_MaterialsDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["MaterialID"].Value = Guid.NewGuid();
        }
        private void table_MaterialsDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            BS_DataChanged();
        }
        private void table_MaterialGroupsDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            BS_DataChanged();
        }
        public Form_Materials()
        { InitializeComponent(); }
        /*private void table_MaterialGroupsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.table_MaterialGroupsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cA_DB_DataSet);
        }*/
        private void Form_Materials_Load(object sender, EventArgs e)
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
            this.table_MaterialGroupsBindingSource.EndEdit();
            this.table_MaterialGroupsTableAdapter.Adapter.Update(cA_DB_DataSet);
            this.table_MaterialsBindingSource.EndEdit();
            this.table_MaterialsTableAdapter.Adapter.Update(cA_DB_DataSet);
            this.Text = BS_caption;
        }
        private void button_SaveAndClose_Click(object sender, EventArgs e)
        {
            button_Save_Click(sender, e);
            Close();
        }
    }
}
