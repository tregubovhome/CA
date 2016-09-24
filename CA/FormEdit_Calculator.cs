using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA
{
    public partial class FormEdit_Calculator : Form
    {
        public double Value
        {
            get { return Convert.ToDouble(textBox.Text); }
        }
        private double oldValue;
        private string text;
        private double First;
        private double Second;
        private bool OperationButtonPressed = true;
        private string Operation = "";
        private void UpdateTextBox()
        {
            if (text.Contains(','))
                if (text.Substring(text.Length - 1, 1).Equals(",")) //последняя запятая
                    textBox.Text = Convert.ToDouble(text.Substring(0, text.Length - 1)).ToString("N0", CultureInfo.CreateSpecificCulture("ru").NumberFormat)
                                   + ",";
                else //уже есть дробная часть
                    textBox.Text = Convert.ToDouble(text.Substring(0, text.IndexOf(','))).ToString("N0", CultureInfo.CreateSpecificCulture("ru").NumberFormat)
                                   + text.Substring(text.IndexOf(','));
            else //целое число
                textBox.Text = Convert.ToDouble(text).ToString("N0", CultureInfo.CreateSpecificCulture("ru").NumberFormat);
        }
        private void NumberPress(string _symbol)
        {
            if (text.Contains(',') && _symbol == ",") //запятая уже есть
                return;
            if (OperationButtonPressed) //начало ввода нового числа
            {
                if (Operation != "")
                    buttonEqual.Text = "=";
                if (_symbol == ",")
                    text = "0,";
                else //цифра
                    text = _symbol;
                OperationButtonPressed = false;
            }
            else //продолжение ввода текущего числа
                if (text == "0") //замена одинокого ноля (кот. является результатом BackSpace) на первую цифру
                    text = _symbol;
                else
                    text += _symbol;
            if (Operation == "")
                buttonEqual.Text = "Ок";
            UpdateTextBox();
            this.buttonEqual.Focus();
        }
        private void OperationPress(string _button)
        {
            if (_button == "Equal")
            {
                if ((OperationButtonPressed && Operation == "Equal") ||//нажато = 2 раза подряд (без цифр и пр.) или
                    Operation == "")  // нажато = сразу при входе
                    OkPress();
                buttonEqual.Text = "Ок";
            }
            else
                buttonEqual.Text = "=";
            if (Operation != "") //уже ранее нажималась операция
            {
                Second = Convert.ToDouble(text);
                switch (Operation)
                {
                    case "Plus":
                        text = (First + Second).ToString(); break;
                    case "Minus":
                        text = (First - Second).ToString(); break;
                    case "Multiply":
                        text = (First * Second).ToString(); break;
                    case "Division":
                        text = (First / Second).ToString(); break;
                }
            }
            Operation = _button; //заносим новую (следующую) операцию в память
            OperationButtonPressed = true;
            First = Convert.ToDouble(text);
            UpdateTextBox();
            this.buttonEqual.Focus();
        }
        private void BackSpacePress()
        {
            text = text.Substring(0, text.Length - 1);
            if (text == "")
                text = "0";
            UpdateTextBox();
            this.buttonEqual.Focus();
        }
        private void CancelPress()
        {
            text = oldValue.ToString();
            UpdateTextBox();
            Close();
        }
        private void OkPress()
        {
            Close();
        }
        public FormEdit_Calculator()
        { InitializeComponent(); }
        public FormEdit_Calculator(string _oldValue)
        {
            InitializeComponent();
            if (_oldValue == "")
                _oldValue = "0";
            oldValue = Convert.ToDouble(_oldValue);
            text = oldValue.ToString();
            UpdateTextBox();
            this.buttonEqual.Focus();
        }
        private void Form_Calculator_Load(object sender, EventArgs e)
        {
            Left = Cursor.Position.X + 3;
            Top = Cursor.Position.Y + 3;
        }
        private void Form_Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                case Keys.D0:
                    NumberPress("0"); break;
                case Keys.NumPad1:
                case Keys.D1:
                    NumberPress("1"); break;
                case Keys.NumPad2:
                case Keys.D2:
                    NumberPress("2"); break;
                case Keys.NumPad3:
                case Keys.D3:
                    NumberPress("3"); break;
                case Keys.NumPad4:
                case Keys.D4:
                    NumberPress("4"); break;
                case Keys.NumPad5:
                case Keys.D5:
                    NumberPress("5"); break;
                case Keys.NumPad6:
                case Keys.D6:
                    NumberPress("6"); break;
                case Keys.NumPad7:
                case Keys.D7:
                    NumberPress("7"); break;
                case Keys.NumPad8:
                case Keys.D8:
                    NumberPress("8"); break;
                case Keys.NumPad9:
                case Keys.D9:
                    NumberPress("9"); break;
                case Keys.Decimal:
                case Keys.Oemcomma:
                case Keys.OemSemicolon:
                case Keys.OemPeriod:
                    NumberPress(","); break;
                case Keys.Oemplus:
                case Keys.Add:
                    OperationPress("Plus"); break;
                case Keys.OemMinus:
                case Keys.Subtract:
                    OperationPress("Minus"); break;
                case Keys.Multiply:
                    OperationPress("Multiply"); break;
                case Keys.OemBackslash:
                case Keys.Divide:
                case Keys.OemPipe:
                    OperationPress("Division"); break;
                case Keys.Enter:
                    OperationPress("Equal"); break;
                case Keys.Escape:
                case Keys.Cancel:
                    CancelPress();
                    break;
                case Keys.Back:
                case Keys.Delete:
                    BackSpacePress();
                    break;
                default: return;
            }
        }
        private void buttonPlus_Click(object sender, EventArgs e)
        { OperationPress("Plus"); }
        private void buttonMinus_Click(object sender, EventArgs e)
        { OperationPress("Minus"); }
        private void buttonMultiply_Click(object sender, EventArgs e)
        { OperationPress("Multiply"); }
        private void buttonDivision_Click(object sender, EventArgs e)
        { OperationPress("Division"); }
        private void buttonEqual_Click(object sender, EventArgs e)
        { OperationPress("Equal"); }
        private void buttonPoint_Click(object sender, EventArgs e)
        { NumberPress(","); }
        private void button0_Click(object sender, EventArgs e)
        { NumberPress("0"); }
        private void button1_Click(object sender, EventArgs e)
        { NumberPress("1"); }
        private void button2_Click(object sender, EventArgs e)
        { NumberPress("2"); }
        private void button3_Click(object sender, EventArgs e)
        { NumberPress("3"); }
        private void button4_Click(object sender, EventArgs e)
        { NumberPress("4"); }
        private void button5_Click(object sender, EventArgs e)
        { NumberPress("5"); }
        private void button6_Click(object sender, EventArgs e)
        { NumberPress("6"); }
        private void button7_Click(object sender, EventArgs e)
        { NumberPress("7"); }
        private void button8_Click(object sender, EventArgs e)
        { NumberPress("8"); }
        private void button9_Click(object sender, EventArgs e)
        { NumberPress("9"); }
        private void buttonBackSpace_Click(object sender, EventArgs e)
        { BackSpacePress(); }
        private void buttonCancel_Click(object sender, EventArgs e)
        { CancelPress(); }
        private void buttonOk_Click(object sender, EventArgs e)
        { OkPress(); }
    }
}