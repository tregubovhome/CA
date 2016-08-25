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
    public partial class Form_MoneyMove : Form_BaseStyle
    {
        private bool CreateNew = false;
        private Guid id = Guid.Empty;
        DateTime Date = DateTime.Now;
        double Sum = 0;
        bool IsCash = false;
        Guid ExpensesType = Guid.Empty;
        Guid Project = Guid.Empty;
        Guid Employee = Guid.Empty;
        string Description = "";

        /*public Form_MoneyMove()
        {
            InitializeComponent();
        }*/
        public Form_MoneyMove(Guid _id)//редактирование
        {
            InitializeComponent();
            id = _id;
        }
        public Form_MoneyMove(bool _CreateNew, Guid _id)//создание
        {
            InitializeComponent();
            CreateNew = _CreateNew;
            id = _id;
        }
        public Form_MoneyMove(bool _CreateNew, Guid _id, DateTime _Date, double _Sum, bool _IsCash, string _ExpensesType, string _Project, string _Employee, string _Description)//клонирование
        {
            InitializeComponent();
            CreateNew = _CreateNew;
            id = _id;
            DateTime Date = DateTime.Now;
            Sum = _Sum;
            IsCash = _IsCash;
            ExpensesType = (_ExpensesType != "") ? Guid.Parse(_ExpensesType) : Guid.Empty;
            Project = (_Project != "") ? Guid.Parse(_Project) : Guid.Empty;
            Employee = (_Employee != "") ? Guid.Parse(_Employee) : Guid.Empty;
            Description = _Description;
        }
        /*private void table_MoneyMovesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            table_MoneyMovesBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(cA_DB_DataSet);
        }*/
        private void Form_MoneyMove_Load(object sender, EventArgs e)
        {   // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_Projects". При необходимости она может быть перемещена или удалена.
            this.table_ProjectsTableAdapter.Fill(this.cA_DB_DataSet.Table_Projects);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_Employees". При необходимости она может быть перемещена или удалена.
            this.table_EmployeesTableAdapter.Fill(this.cA_DB_DataSet.Table_Employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_ExpensesTypes". При необходимости она может быть перемещена или удалена.
            this.table_ExpensesTypesTableAdapter.Fill(this.cA_DB_DataSet.Table_ExpensesTypes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_MoneyMoves". При необходимости она может быть перемещена или удалена.
            table_MoneyMovesTableAdapter.Fill(cA_DB_DataSet.Table_MoneyMoves);
            if (CreateNew == true)//создание или клонирование
            {
                table_MoneyMovesBindingSource.AddNew();
                idTextBox.Text = id.ToString();
                dateDateTimePicker.Value = Date;
                sumTextBox.Text = Sum.ToString();
                isCashCheckBox.CheckState = (IsCash == true) ? CheckState.Checked : CheckState.Unchecked;
                expensesTypeComboBox.Text = "";
                projectComboBox.Text = "";
                employeeComboBox.Text = "";
                descriptionTextBox.Text = Description;
            }
            else//редактирование
            {
                table_MoneyMovesBindingSource.Filter = "id = '" + id.ToString() + "'";
            }
        }
        private void button_SaveCurrent_Click(object sender, EventArgs e)
        {
            Validate();
            table_MoneyMovesBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(cA_DB_DataSet);
        }
        private void button_SaveCurrentAndClose_Click(object sender, EventArgs e)
        {
            Validate();
            table_MoneyMovesBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(cA_DB_DataSet);
            Close();
        }

        private void Form_MoneyMove_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
