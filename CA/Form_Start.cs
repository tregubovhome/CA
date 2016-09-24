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
            this.Hide();
            Form_MoneyFlow form_MoneyFlow = new Form_MoneyFlow();
            form_MoneyFlow.ShowDialog();
            this.Show();
        }
        private void button_Projects_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Projects form_Projects = new Form_Projects();
            form_Projects.ShowDialog();
            this.Show();
        }
        private void button_Companies_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Companies form_Companies = new Form_Companies();
            form_Companies.ShowDialog();
            this.Show();
        }
        private void button_Employees_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Employees form_Employees = new Form_Employees();
            form_Employees.ShowDialog();
            this.Show();
        }
        private void button_Materials_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Materials form_Materials = new Form_Materials();
            form_Materials.ShowDialog();
            this.Show();
        }
        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
