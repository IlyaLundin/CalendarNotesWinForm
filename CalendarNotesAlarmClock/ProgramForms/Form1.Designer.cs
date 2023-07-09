namespace CalendarNotesAlarmClock
{
    partial class Form1
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
            this.buttonSetNote = new System.Windows.Forms.Button();
            this.buttonClock = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSetNote
            // 
            this.buttonSetNote.Location = new System.Drawing.Point(297, 216);
            this.buttonSetNote.Name = "buttonSetNote";
            this.buttonSetNote.Size = new System.Drawing.Size(96, 44);
            this.buttonSetNote.TabIndex = 0;
            this.buttonSetNote.Text = "Сделать заметку";
            this.buttonSetNote.UseVisualStyleBackColor = true;
            // 
            // buttonClock
            // 
            this.buttonClock.Location = new System.Drawing.Point(412, 216);
            this.buttonClock.Name = "buttonClock";
            this.buttonClock.Size = new System.Drawing.Size(96, 44);
            this.buttonClock.TabIndex = 1;
            this.buttonClock.Text = "Будильник";
            this.buttonClock.UseVisualStyleBackColor = true;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(181, 216);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(96, 44);
            this.buttonHelp.TabIndex = 2;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(181, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(212, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(181, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(327, 20);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonClock);
            this.Controls.Add(this.buttonSetNote);
            this.MaximumSize = new System.Drawing.Size(800, 400);
            this.MinimumSize = new System.Drawing.Size(350, 200);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSetNote;
        private System.Windows.Forms.Button buttonClock;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

