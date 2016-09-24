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
    public partial class Form_ProjectCurrent : Form_BaseStyle
    {
        private Guid currID;
        public override void BS_Fill()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_ProjectStatuses". При необходимости она может быть перемещена или удалена.
            this.table_ProjectStatusesTableAdapter.Fill(this.cA_DB_DataSet.Table_ProjectStatuses);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_Companies". При необходимости она может быть перемещена или удалена.
            this.table_CompaniesTableAdapter.Fill(this.cA_DB_DataSet.Table_Companies);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_Materials". При необходимости она может быть перемещена или удалена.
            this.table_MaterialsTableAdapter.Fill(this.cA_DB_DataSet.Table_Materials);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_TEOMaterials". При необходимости она может быть перемещена или удалена.
            this.table_TEOMaterialsTableAdapter.Fill(this.cA_DB_DataSet.Table_TEOMaterials);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_ProductionStages". При необходимости она может быть перемещена или удалена.
            this.table_ProductionStagesTableAdapter.Fill(this.cA_DB_DataSet.Table_ProductionStages);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_Projects". При необходимости она может быть перемещена или удалена.
            this.table_ProjectsTableAdapter.Fill(this.cA_DB_DataSet.Table_Projects);
        }
        public override void BS_Save()
        {
            this.table_CompaniesBindingSource.EndEdit();
            this.table_CompaniesTableAdapter.Adapter.Update(cA_DB_DataSet);
            this.table_EmployeesBindingSource.EndEdit();
            this.table_EmployeesTableAdapter.Adapter.Update(cA_DB_DataSet);
        }
        private void table_TEOMaterialsDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["TEOMaterialID"].Value = Guid.NewGuid();
        }
        private void table_TEOMaterialsDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            BS_SpecialEdit(sender as DataGridView, e);
        }
        private void table_TEOMaterialsDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //добавить проверку корректности внесенных данных
            if (e.RowIndex == -1) return;
            if (e.RowIndex == (sender as DataGridView).RowCount - 1) return;
            BS_Save();
        }
        public Form_ProjectCurrent()
        { InitializeComponent(); }
        public Form_ProjectCurrent(Guid _currID)
        {
            InitializeComponent();
            table_ProjectsBindingSource.Filter = "id = '" + _currID.ToString() + "'";
            currID = _currID;
        }
        private void Form_ProjectCurrent_Load(object sender, EventArgs e)
        {
            BS_Fill();
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            BS_Refresh(table_CompaniesDataGridView, table_EmployeesDataGridView);
        }
        
    }
}
