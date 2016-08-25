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
    public partial class Form_Start : Form_BaseStyle
    {
        public Form_Start()
        {
            InitializeComponent();
        }
        private void button_Employees_Click(object sender, EventArgs e)
        {
            Form_Employees form_Employees = new Form_Employees();
            form_Employees.ShowDialog();
        }
        private void button_MoneyMoves_Click(object sender, EventArgs e)
        {
            Form_MoneyMoves form_MoneyMoves = new Form_MoneyMoves();
            form_MoneyMoves.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_MoneyMoves_222 form_MoneyMoves = new Form_MoneyMoves_222();
            form_MoneyMoves.ShowDialog();
        }
    }
}
