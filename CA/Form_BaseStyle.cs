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
        public virtual string BS_caption
        {
            set { BS_caption = value; }
            get { return "Form_BaseStyle"; }
        }
        public virtual void BS_LoadData() { }
        public virtual void BS_Fill() { }
        public void BS_DataChanged()
        {
            this.Text = BS_caption + " * [ изменения не сохранены ]";
        }
        public void BS_Refresh()
        {
            if (this.Text == BS_caption) //изменений поль-ль не вносил
                BS_LoadData();
            else //изменения вносились
                if (MessageBox.Show("Внесённые изменения будут утеряны. Продолжить?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    BS_LoadData();
        }
        public Form_BaseStyle()
        { InitializeComponent(); }
    }
}
