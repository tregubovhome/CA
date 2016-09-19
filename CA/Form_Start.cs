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
    public partial class Form_Start : Form
    {
        public Form_Start()
        { InitializeComponent(); }
        private void button_MoneyMoves_Click(object sender, EventArgs e)
        {
            Form_MoneyFlow form_MoneyFlow = new Form_MoneyFlow();
            form_MoneyFlow.ShowDialog();
        }
        private void button_Companies_Click(object sender, EventArgs e)
        {
            Form_Companies form_Companies = new Form_Companies();
            form_Companies.ShowDialog();
        }
        private void button_Employees_Click(object sender, EventArgs e)
        {
            Form_Employees form_Employees = new Form_Employees();
            form_Employees.ShowDialog();
        }
        private void button_Materials_Click(object sender, EventArgs e)
        {
            Form_Materials form_Materials = new Form_Materials();
            form_Materials.ShowDialog();
        }
    }
}
