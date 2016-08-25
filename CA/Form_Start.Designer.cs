namespace CA
{
    partial class Form_Start : Form_BaseStyle
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Employees = new System.Windows.Forms.Button();
            this.button_MoneyMoves = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Employees
            // 
            this.button_Employees.Location = new System.Drawing.Point(525, 162);
            this.button_Employees.Name = "button_Employees";
            this.button_Employees.Size = new System.Drawing.Size(147, 62);
            this.button_Employees.TabIndex = 0;
            this.button_Employees.Text = "button_Employees";
            this.button_Employees.UseVisualStyleBackColor = true;
            this.button_Employees.Click += new System.EventHandler(this.button_Employees_Click);
            // 
            // button_MoneyMoves
            // 
            this.button_MoneyMoves.Location = new System.Drawing.Point(12, 12);
            this.button_MoneyMoves.Name = "button_MoneyMoves";
            this.button_MoneyMoves.Size = new System.Drawing.Size(147, 62);
            this.button_MoneyMoves.TabIndex = 0;
            this.button_MoneyMoves.Text = "button_MoneyMoves";
            this.button_MoneyMoves.UseVisualStyleBackColor = true;
            this.button_MoneyMoves.Click += new System.EventHandler(this.button_MoneyMoves_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "button_MoneyMoves";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 337);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_MoneyMoves);
            this.Controls.Add(this.button_Employees);
            this.Name = "Form_Start";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Employees;
        private System.Windows.Forms.Button button_MoneyMoves;
        private System.Windows.Forms.Button button1;
    }
}

