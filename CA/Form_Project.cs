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
    public partial class Form_Project : Form_BaseStyle
    {
        public Form_Project()
        {
            InitializeComponent();
        }

        private void Form_Project_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_MoneyMoves". При необходимости она может быть перемещена или удалена.
            this.table_MoneyMovesTableAdapter.Fill(this.cA_DB_DataSet.Table_MoneyMoves);

        }
    }
}
