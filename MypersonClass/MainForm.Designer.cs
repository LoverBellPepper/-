namespace MypersonClass
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Heading = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DisplayRecord = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Heading
            // 
            this.Heading.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Heading.Location = new System.Drawing.Point(12, 46);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(507, 46);
            this.Heading.TabIndex = 0;
            this.Heading.Text = "Введите имя, фамилию и дату рождения сотрудника";
            this.Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // Name
            // 
            this.Name.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.Name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name.ForeColor = System.Drawing.Color.Silver;
            this.Name.Location = new System.Drawing.Point(16, 108);
            this.Name.Multiline = true;
            this.Name.Name = "Name";
            this.Name.ShortcutsEnabled = false;
            this.Name.Size = new System.Drawing.Size(301, 34);
            this.Name.TabIndex = 2;
            this.Name.Enter += new System.EventHandler(this.Name_Enter);
            this.Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_KeyPress);
            this.Name.Leave += new System.EventHandler(this.Name_Leave);
            // 
            // Surname
            // 
            this.Surname.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.Surname.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.Surname.ForeColor = System.Drawing.Color.Silver;
            this.Surname.Location = new System.Drawing.Point(16, 172);
            this.Surname.Multiline = true;
            this.Surname.Name = "Surname";
            this.Surname.ShortcutsEnabled = false;
            this.Surname.Size = new System.Drawing.Size(301, 34);
            this.Surname.TabIndex = 3;
            this.Surname.Enter += new System.EventHandler(this.Surname_Enter);
            this.Surname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_KeyPress);
            this.Surname.Leave += new System.EventHandler(this.Surname_Leave);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Times New Roman", 14F);
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop;
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 234);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(301, 29);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // DisplayRecord
            // 
            this.DisplayRecord.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DisplayRecord.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.DisplayRecord.FlatAppearance.BorderSize = 3;
            this.DisplayRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisplayRecord.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DisplayRecord.Location = new System.Drawing.Point(362, 278);
            this.DisplayRecord.Name = "DisplayRecord";
            this.DisplayRecord.Size = new System.Drawing.Size(166, 41);
            this.DisplayRecord.TabIndex = 5;
            this.DisplayRecord.Text = "Отобразить запись";
            this.DisplayRecord.UseVisualStyleBackColor = false;
            this.DisplayRecord.Click += new System.EventHandler(this.DisplayRecord_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Close.Location = new System.Drawing.Point(495, 9);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(33, 33);
            this.Close.TabIndex = 6;
            this.Close.Text = "✖";
            this.Close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(16, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Включен Caps Lock. Для ввода данных выключите.";
            this.label1.Visible = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(16, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(365, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Включена английская раскладка. Переключитесь на русскую.";
            this.label3.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(540, 336);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.DisplayRecord);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Heading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button DisplayRecord;
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

