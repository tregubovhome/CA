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
    public partial class Form_BaseStyle : Form
    {
        public virtual void BS_Fill() { }
        public virtual void BS_Refresh(DataGridView dgvMaster, DataGridView dgvSlave)
        {
            Guid _currMasterID = (dgvMaster.CurrentRow != null) ? (Guid)dgvMaster[0, dgvMaster.CurrentRow.Index].Value : Guid.Empty;
            Guid _currSlaveID = (dgvSlave.CurrentRow != null) ? (Guid)dgvSlave[0, dgvSlave.CurrentRow.Index].Value : Guid.Empty;
            BS_Fill();
            if (_currMasterID != Guid.Empty)
            {
                BindingSource bs = dgvMaster.DataSource as BindingSource;
                bs.Position = bs.Find("id", _currMasterID);
                //this.tableProjectsBindingSource.Position = this.tableProjectsBindingSource.Find("id", _currMasterID);
            }
            if (_currSlaveID != Guid.Empty)
            {
                DataGridViewRow row = dgvSlave.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.IsNewRow.Equals(false))
                    .Where(r => r.Cells[0].Value.ToString().Equals(_currSlaveID.ToString()))
                    .First();
                BindingSource bs = dgvSlave.DataSource as BindingSource;
                bs.Position = row.Index;
                //this.table_MoneyFlowBindingSource.Position = row.Index;
            }
        }
        public virtual void BS_Save() { }
        public void BS_DeleteRow(DataGridView dgv)
        {
            DataGridViewRow r = dgv.CurrentRow;// .Rows[dgv.SelectedCells[0].RowIndex];
            if (MessageBox.Show("Удалить?  currRow=" + r.Index, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dgv.Rows.Remove(r);
                BS_Save();
            }
        }
        public void BS_SpecialEdit(DataGridView dgv, DataGridViewCellCancelEventArgs e)
        {
            if (dgv.Columns[e.ColumnIndex].ValueType.Name.Equals("DateTime"))
            {
                FormEdit_Calendar form = new FormEdit_Calendar((DateTime)dgv[e.ColumnIndex, e.RowIndex].Value);
                form.ShowDialog();
                dgv[e.ColumnIndex, e.RowIndex].Value = form.Value;
                EndEdit();
            }
            else if (dgv.Columns[e.ColumnIndex].ValueType.Name.Equals("Decimal"))
            {
                FormEdit_Calculator form = new FormEdit_Calculator(dgv[e.ColumnIndex, e.RowIndex].Value.ToString());
                form.ShowDialog();
                dgv[e.ColumnIndex, e.RowIndex].Value = form.Value;
                EndEdit();
            }
        }
        private void EndEdit()
        {
            SendKeys.Send("{Right}");
            SendKeys.Send("{Right}");
            SendKeys.Send("{Left}");
            /*DataGridViewEditMode oldMode = dgv.EditMode;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv.EndEdit();
            dgv.EditMode = oldMode;*/
        }
        public Form_BaseStyle()
        { InitializeComponent(); }
    }
}