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
    public partial class Form_MoneyMoves : Form_BaseStyle
    {
        private Guid CurrentID = Guid.Empty;
        public Form_MoneyMoves()
        {
            InitializeComponent();
        }
        private void table_MoneyMovesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            table_MoneyMovesBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(cA_DB_DataSet);
        }
        private void Form_MoneyMoves_Load(object sender, EventArgs e)
        {// TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_ExpensesTypes". При необходимости она может быть перемещена или удалена.
            this.table_ExpensesTypesTableAdapter.Fill(this.cA_DB_DataSet.Table_ExpensesTypes);
   // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_MoneyMoves". При необходимости она может быть перемещена или удалена.
            table_MoneyMovesTableAdapter.Fill(cA_DB_DataSet.Table_MoneyMoves);
        }
        private void button_CreateNew_Click(object sender, EventArgs e)
        {
            CurrentID = Guid.NewGuid();
            Form_MoneyMove form_MoneyMove = new Form_MoneyMove(true, CurrentID);
            form_MoneyMove.ShowDialog();
            table_MoneyMovesTableAdapter.Fill(cA_DB_DataSet.Table_MoneyMoves);
            table_MoneyMovesBindingSource.Position = table_MoneyMovesBindingSource.Find("id", CurrentID);
        }
        private void button_CloneCurrent_Click(object sender, EventArgs e)
        {
            CurrentID = Guid.NewGuid();
            //Guid a = Guid.Parse(table_MoneyMovesDataGridView["dataGridViewTextBoxColumn4", table_MoneyMovesDataGridView.CurrentRow.Index].Value.ToString());
            Form_MoneyMove form_MoneyMove = new Form_MoneyMove(true,
                CurrentID,
                DateTime.Parse(table_MoneyMovesDataGridView["dataGridViewTextBoxColumn2", table_MoneyMovesDataGridView.CurrentRow.Index].Value.ToString()),
                double.Parse(table_MoneyMovesDataGridView["dataGridViewTextBoxColumn3", table_MoneyMovesDataGridView.CurrentRow.Index].Value.ToString()),
                (bool)table_MoneyMovesDataGridView["dataGridViewCheckBoxColumn1", table_MoneyMovesDataGridView.CurrentRow.Index].Value,
                table_MoneyMovesDataGridView["dataGridViewTextBoxColumn4", table_MoneyMovesDataGridView.CurrentRow.Index].Value.ToString(),
                table_MoneyMovesDataGridView["dataGridViewTextBoxColumn5", table_MoneyMovesDataGridView.CurrentRow.Index].Value.ToString(),
                table_MoneyMovesDataGridView["dataGridViewTextBoxColumn6", table_MoneyMovesDataGridView.CurrentRow.Index].Value.ToString(),
                (string)table_MoneyMovesDataGridView["dataGridViewTextBoxColumn7", table_MoneyMovesDataGridView.CurrentRow.Index].Value
                );
            form_MoneyMove.ShowDialog();
            table_MoneyMovesTableAdapter.Fill(cA_DB_DataSet.Table_MoneyMoves);
            table_MoneyMovesBindingSource.Position = table_MoneyMovesBindingSource.Find("id", CurrentID);
        }
        private void table_MoneyMovesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CurrentID = (Guid)table_MoneyMovesDataGridView["dataGridViewTextBoxColumn1", e.RowIndex].Value;
            Form_MoneyMove form_MoneyMove = new Form_MoneyMove(CurrentID);
            form_MoneyMove.ShowDialog();
            table_MoneyMovesTableAdapter.Fill(cA_DB_DataSet.Table_MoneyMoves);
            table_MoneyMovesBindingSource.Position = table_MoneyMovesBindingSource.Find("id", CurrentID);
        }
        private void button_EditCurrent_Click(object sender, EventArgs e)
        {
            CurrentID = (Guid)table_MoneyMovesDataGridView["dataGridViewTextBoxColumn1", table_MoneyMovesDataGridView.CurrentRow.Index].Value;
            Form_MoneyMove form_MoneyMove = new Form_MoneyMove(CurrentID);
            form_MoneyMove.ShowDialog();
            table_MoneyMovesTableAdapter.Fill(cA_DB_DataSet.Table_MoneyMoves);
            table_MoneyMovesBindingSource.Position = table_MoneyMovesBindingSource.Find("id", CurrentID);
        }
        private void button_DeleteCurrent_Click(object sender, EventArgs e)
        {
            CurrentID = (Guid)table_MoneyMovesDataGridView["dataGridViewTextBoxColumn1", table_MoneyMovesDataGridView.CurrentRow.Index].Value;
            int NewPosition = table_MoneyMovesBindingSource.Find("id", CurrentID) - 1;
            if (NewPosition < 0)
                NewPosition = 0;
            table_MoneyMovesTableAdapter.Delete(
                CurrentID,
                (DateTime)table_MoneyMovesDataGridView["dataGridViewTextBoxColumn2", table_MoneyMovesDataGridView.CurrentRow.Index].Value,
                (long)table_MoneyMovesDataGridView["dataGridViewTextBoxColumn3", table_MoneyMovesDataGridView.CurrentRow.Index].Value,
                (bool)table_MoneyMovesDataGridView["dataGridViewTextBoxColumn4", table_MoneyMovesDataGridView.CurrentRow.Index].Value,
                (Guid)table_MoneyMovesDataGridView["dataGridViewTextBoxColumn5", table_MoneyMovesDataGridView.CurrentRow.Index].Value,
                (Guid)table_MoneyMovesDataGridView["dataGridViewTextBoxColumn6", table_MoneyMovesDataGridView.CurrentRow.Index].Value,
                (Guid)table_MoneyMovesDataGridView["dataGridViewTextBoxColumn7", table_MoneyMovesDataGridView.CurrentRow.Index].Value,
                (string)table_MoneyMovesDataGridView["dataGridViewTextBoxColumn8", table_MoneyMovesDataGridView.CurrentRow.Index].Value
                );
            table_MoneyMovesTableAdapter.Fill(cA_DB_DataSet.Table_MoneyMoves);
            table_MoneyMovesBindingSource.Position = NewPosition;
        }
    }
}