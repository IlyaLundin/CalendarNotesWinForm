namespace CalendarNotesAlarmClock
{
    partial class FormMyNotes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMyNotes));
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxMyNotes = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(349, 98);
            this.buttonClose.MaximumSize = new System.Drawing.Size(100, 100);
            this.buttonClose.MinimumSize = new System.Drawing.Size(40, 40);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(96, 44);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxMyNotes
            // 
            this.textBoxMyNotes.Location = new System.Drawing.Point(12, 97);
            this.textBoxMyNotes.MaximumSize = new System.Drawing.Size(200, 300);
            this.textBoxMyNotes.MinimumSize = new System.Drawing.Size(150, 100);
            this.textBoxMyNotes.Multiline = true;
            this.textBoxMyNotes.Name = "textBoxMyNotes";
            this.textBoxMyNotes.ReadOnly = true;
            this.textBoxMyNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxMyNotes.Size = new System.Drawing.Size(200, 300);
            this.textBoxMyNotes.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(218, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 249);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FormMyNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 404);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxMyNotes);
            this.Controls.Add(this.buttonClose);
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "FormMyNotes";
            this.Text = "Мои Заметки";
            this.Load += new System.EventHandler(this.FormMyNotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonClose;
        internal System.Windows.Forms.TextBox textBoxMyNotes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}