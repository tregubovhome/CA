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
    public partial class FormEdit_Calendar : Form
    {
        private DateTime last_mouse_down;
        private DateTime oldValue;
        public DateTime Value
        {
            get { return monthCalendar1.SelectionStart; }
        }
        public FormEdit_Calendar()
        { InitializeComponent(); }
        public FormEdit_Calendar(DateTime _oldValue)
        {
            InitializeComponent();
            monthCalendar1.SelectionStart = _oldValue;
            oldValue = _oldValue;
        }
        private void Form_Calendar_Load(object sender, EventArgs e)
        {
            Left = Cursor.Position.X + 3;
            Top = Cursor.Position.Y + 3;
        }
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            if ((DateTime.Now - last_mouse_down).TotalMilliseconds <= SystemInformation.DoubleClickTime)
                Close();
            last_mouse_down = DateTime.Now;
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            last_mouse_down = DateTime.Now.Subtract(new TimeSpan(1, 0, 0));
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            monthCalendar1.SelectionStart = oldValue;
            Close();
        }
        private void button_Ok_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}