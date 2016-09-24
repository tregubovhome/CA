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
    public partial class Form_Projects : Form_BaseStyle
    {
        public override void BS_Fill()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_Companies". При необходимости она может быть перемещена или удалена.
            this.table_CompaniesTableAdapter.Fill(this.cA_DB_DataSet.Table_Companies);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_ProjectStatuses". При необходимости она может быть перемещена или удалена.
            this.table_ProjectStatusesTableAdapter.Fill(this.cA_DB_DataSet.Table_ProjectStatuses);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_Projects". При необходимости она может быть перемещена или удалена.
            this.table_ProjectsTableAdapter.Fill(this.cA_DB_DataSet.Table_Projects);
        }
        public override void BS_Save()
        {
            this.table_ProjectsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cA_DB_DataSet);
        }
        private void table_ProjectsDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["ProjectID"].Value = Guid.NewGuid();
            DataTable dt = table_ProjectsTableAdapter.GetData();
            int dtmax = dt.AsEnumerable()
                .Select(r => r.Field<int>("Num"))
                .Distinct()
                .Max();
            e.Row.Cells["ProjectNum"].Value = dtmax + 1;
            e.Row.Cells["ProjectDate"].Value = DateTime.Today;
            e.Row.Cells["ProjectName"].Value = "имя";
            e.Row.Cells["ProjectMargin"].Value = 40;
        }
        private void table_ProjectsDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            BS_SpecialEdit(sender as DataGridView, e);
            /*if ((sender as DataGridView).Columns[e.ColumnIndex].ValueType.Name.Equals("DateTime"))
                BS_ChooseValueByCalendar(sender as DataGridView, e);
            else if ((sender as DataGridView).Columns[e.ColumnIndex].ValueType.Name.Equals("Decimal"))
                BS_ChooseValueByCalculator(sender as DataGridView, e);*/
            //MessageBox.Show((sender as DataGridView).Columns[e.ColumnIndex].ValueType.Name);
        }
        private void table_ProjectsDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (e.RowIndex == (sender as DataGridView).RowCount - 1) return;
            BS_Save();
        }
        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            //BS_DeleteRow(table_ProjectsDataGridView);// ссылки в базе !!!
        }
        public Form_Projects()
        { InitializeComponent(); }
        /*private void table_ProjectsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.table_ProjectsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cA_DB_DataSet);
        }*/
        private void Form_Projects_Load(object sender, EventArgs e)
        {
            BS_Fill();
            table_ProjectsBindingSource.Filter = "Name <> '[ пусто ]'";
        }
        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_ProjectCurrent form_ProjectCurrent = new Form_ProjectCurrent((Guid)table_ProjectsDataGridView["ProjectID", table_ProjectsDataGridView.CurrentRow.Index].Value);
            form_ProjectCurrent.ShowDialog();
            this.Show();
        }
    }
}