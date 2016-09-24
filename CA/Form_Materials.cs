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
        public override void BS_Fill()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_MeasureUnits". При необходимости она может быть перемещена или удалена.
            this.table_MeasureUnitsTableAdapter.Fill(this.cA_DB_DataSet.Table_MeasureUnits);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_Sections". При необходимости она может быть перемещена или удалена.
            this.table_SectionsTableAdapter.Fill(this.cA_DB_DataSet.Table_Sections);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_MeasureUnits". При необходимости она может быть перемещена или удалена.
            //this.table_MeasureUnitsTableAdapter.Fill(this.cA_DB_DataSet.Table_MeasureUnits);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_Sections". При необходимости она может быть перемещена или удалена.
            //this.table_SectionsTableAdapter.Fill(this.cA_DB_DataSet.Table_Sections);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_Materials". При необходимости она может быть перемещена или удалена.
            this.table_MaterialsTableAdapter.Fill(this.cA_DB_DataSet.Table_Materials);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_MaterialGroups". При необходимости она может быть перемещена или удалена.
            this.table_MaterialGroupsTableAdapter.Fill(this.cA_DB_DataSet.Table_MaterialGroups);
        }
        public override void BS_Save()
        {
            this.table_MaterialGroupsBindingSource.EndEdit();
            this.table_MaterialGroupsTableAdapter.Adapter.Update(cA_DB_DataSet);
            this.table_MaterialsBindingSource.EndEdit();
            this.table_MaterialsTableAdapter.Adapter.Update(cA_DB_DataSet);
        }
        private void table_MaterialGroupsDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["GroupID"].Value = Guid.NewGuid();
        }
        private void table_MaterialsDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["MaterialID"].Value = Guid.NewGuid();
            e.Row.Cells["IsWork"].Value = false;
            e.Row.Cells["MaterialName"].Value = "наименование";
            e.Row.Cells["MaterialMeasureUnitID"].Value = "8da54887-aace-4bc6-b0c6-34a3fa037b39";
            e.Row.Cells["MaterialSectionID"].Value = comboBoxSection.SelectedValue;
        }
        private void table_MaterialsDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            BS_SpecialEdit(sender as DataGridView, e);
        }
        private void table_MaterialsDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //добавить проверку корректности внесенных данных
            if (e.RowIndex == -1) return;
            if (e.RowIndex == (sender as DataGridView).RowCount - 1) return;
            BS_Save();
        }
        private void table_MaterialGroupsDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (e.RowIndex == (sender as DataGridView).RowCount - 1) return;
            BS_Save();
        }
        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            //BS_DeleteRow(table_MaterialsDataGridView); ссылки в базе !!!
        }
        private void toolStripButtonDeleteGroup_Click(object sender, EventArgs e)
        {
            //BS_DeleteRow(table_MaterialGroupsDataGridView); Придумать как удалять/перемещать материалы удаляемой группы
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
            BS_Refresh(table_MaterialGroupsDataGridView, table_MaterialsDataGridView);
        }
        private void comboBoxSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSection.SelectedValue != null)
                table_MaterialsBindingSource.Filter = "SectionID = '" + comboBoxSection.SelectedValue + "'";
            else
                table_MaterialsBindingSource.Filter = "";
        }
        private void button_MeasureUnits_Click(object sender, EventArgs e)
        {
            Form_MeasureUnits form_MeasureUnits = new Form_MeasureUnits();
            form_MeasureUnits.ShowDialog();
        }
    }
}