namespace CA
{
    partial class Form_Start
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
            this.button_Companies = new System.Windows.Forms.Button();
            this.button_Materials = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Employees
            // 
            this.button_Employees.Location = new System.Drawing.Point(525, 80);
            this.button_Employees.Name = "button_Employees";
            this.button_Employees.Size = new System.Drawing.Size(147, 62);
            this.button_Employees.TabIndex = 0;
            this.button_Employees.Text = "Сотрудники";
            this.button_Employees.UseVisualStyleBackColor = true;
            this.button_Employees.Click += new System.EventHandler(this.button_Employees_Click);
            // 
            // button_MoneyMoves
            // 
            this.button_MoneyMoves.Location = new System.Drawing.Point(12, 12);
            this.button_MoneyMoves.Name = "button_MoneyMoves";
            this.button_MoneyMoves.Size = new System.Drawing.Size(147, 62);
            this.button_MoneyMoves.TabIndex = 0;
            this.button_MoneyMoves.Text = "Расходы и поступления";
            this.button_MoneyMoves.UseVisualStyleBackColor = true;
            this.button_MoneyMoves.Click += new System.EventHandler(this.button_MoneyMoves_Click);
            // 
            // button_Companies
            // 
            this.button_Companies.Location = new System.Drawing.Point(525, 12);
            this.button_Companies.Name = "button_Companies";
            this.button_Companies.Size = new System.Drawing.Size(147, 62);
            this.button_Companies.TabIndex = 0;
            this.button_Companies.Text = "Организации";
            this.button_Companies.UseVisualStyleBackColor = true;
            this.button_Companies.Click += new System.EventHandler(this.button_Companies_Click);
            // 
            // button_Materials
            // 
            this.button_Materials.Location = new System.Drawing.Point(525, 148);
            this.button_Materials.Name = "button_Materials";
            this.button_Materials.Size = new System.Drawing.Size(147, 62);
            this.button_Materials.TabIndex = 0;
            this.button_Materials.Text = "Материалы";
            this.button_Materials.UseVisualStyleBackColor = true;
            this.button_Materials.Click += new System.EventHandler(this.button_Materials_Click);
            // 
            // Form_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 337);
            this.Controls.Add(this.button_Companies);
            this.Controls.Add(this.button_MoneyMoves);
            this.Controls.Add(this.button_Materials);
            this.Controls.Add(this.button_Employees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СА";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Employees;
        private System.Windows.Forms.Button button_MoneyMoves;
        private System.Windows.Forms.Button button_Companies;
        private System.Windows.Forms.Button button_Materials;
    }
}

