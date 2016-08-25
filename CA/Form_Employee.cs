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
    public partial class Form_Employee : Form_BaseStyle
    {
        private bool CreateNew = false;
        private Guid id = Guid.Empty;
        string LastName = "";
        string FirstName = "";
        string MiddleName = "";
        /*public Form_Employee()
        {
            InitializeComponent();
        }*/
        public Form_Employee(Guid _id)//редактирование
        {
            InitializeComponent();
            id = _id;
        }
        public Form_Employee(bool _CreateNew, Guid _id)//создание
        {
            InitializeComponent();
            CreateNew = _CreateNew;
            id = _id;
        }
        public Form_Employee(bool _CreateNew, Guid _id, string _LastName, string _FirstName, string _MiddleName)//клонирование
        {
            InitializeComponent();
            CreateNew = _CreateNew;
            id = _id;
            LastName = _LastName;
            FirstName = _FirstName;
            MiddleName = _MiddleName;
        }
        /*private void table_EmployeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            table_EmployeesBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.cA_DB_DataSet);
        }*/
        private void Form_Employee_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cA_DB_DataSet.Table_Employees". При необходимости она может быть перемещена или удалена.
            table_EmployeesTableAdapter.Fill(cA_DB_DataSet.Table_Employees);
            if (CreateNew == true)//создание или клонирование
            {
                table_EmployeesBindingSource.AddNew();
                idTextBox.Text = id.ToString();
                lastNameTextBox.Text = LastName;
                firstNameTextBox.Text = FirstName;
                middleNameTextBox.Text = MiddleName;
            }
            else//редактирование
            {
                table_EmployeesBindingSource.Filter = "id = '" + id.ToString() + "'";
            }
        }
        private void button_SaveCurrent_Click(object sender, EventArgs e)
        {
            Validate();
            table_EmployeesBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(cA_DB_DataSet);
        }
        private void button_SaveCurrentAndClose_Click(object sender, EventArgs e)
        {
            Validate();
            table_EmployeesBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(cA_DB_DataSet);
            Close();
        }
    }
}
