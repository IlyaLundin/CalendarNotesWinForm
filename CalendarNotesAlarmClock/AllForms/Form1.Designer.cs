namespace CalendarNotesAlarmClock
{
    partial class FormWork
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
            this.buttonHelp = new System.Windows.Forms.Button();
            this.dateTimePickerWork = new System.Windows.Forms.DateTimePicker();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.buttonMyNotes = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
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
            this.buttonSetNote.Click += new System.EventHandler(this.buttonSetNote_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(412, 61);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(96, 44);
            this.buttonHelp.TabIndex = 2;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // dateTimePickerWork
            // 
            this.dateTimePickerWork.Location = new System.Drawing.Point(181, 61);
            this.dateTimePickerWork.Name = "dateTimePickerWork";
            this.dateTimePickerWork.Size = new System.Drawing.Size(212, 20);
            this.dateTimePickerWork.TabIndex = 3;
            // 
            // textBoxNote
            // 
            this.textBoxNote.Location = new System.Drawing.Point(181, 122);
            this.textBoxNote.MaxLength = 500;
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxNote.Size = new System.Drawing.Size(327, 72);
            this.textBoxNote.TabIndex = 4;
            this.textBoxNote.TextChanged += new System.EventHandler(this.textBoxNote_TextChanged);
            // 
            // buttonMyNotes
            // 
            this.buttonMyNotes.Location = new System.Drawing.Point(181, 216);
            this.buttonMyNotes.Name = "buttonMyNotes";
            this.buttonMyNotes.Size = new System.Drawing.Size(96, 44);
            this.buttonMyNotes.TabIndex = 5;
            this.buttonMyNotes.Text = "Открыть заметки";
            this.buttonMyNotes.UseVisualStyleBackColor = true;
            this.buttonMyNotes.Click += new System.EventHandler(this.buttonMyNotes_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(412, 216);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(96, 44);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 361);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonMyNotes);
            this.Controls.Add(this.textBoxNote);
            this.Controls.Add(this.dateTimePickerWork);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonSetNote);
            this.MaximumSize = new System.Drawing.Size(800, 400);
            this.MinimumSize = new System.Drawing.Size(350, 200);
            this.Name = "FormWork";
            this.Text = "Календарные заметки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSetNote;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.DateTimePicker dateTimePickerWork;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.Button buttonMyNotes;
        private System.Windows.Forms.Button buttonExit;
    }
}

