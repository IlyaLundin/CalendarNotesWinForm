using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/// <summary>
/// Форма входа в программу и создания заметок
/// </summary>
namespace CalendarNotesAlarmClock
{
    public partial class FormWork : Form
    {
        public FormWork()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Кнопка создания заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetNote_Click(object sender, EventArgs e)
        {
            if (textBoxNote.Text != null && textBoxNote.Text != "")
            {
                using (StreamWriter writerFirst = new StreamWriter("UserFiles\\MyNotes.txt", true))
                {

                    writerFirst.WriteLine(dateTimePickerWork.Value);
                    writerFirst.WriteLine(textBoxNote.Text);
                    writerFirst.WriteLine(" ");
                    writerFirst.Close();
                }
            }
            else
            {
                MessageBox.Show("Не все данные внесены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
        private void textBoxNote_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Кнопка открытия формы просмотра заметок
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMyNotes_Click(object sender, EventArgs e)
        {
            using (StreamReader readerFirst = new StreamReader("UserFiles\\MyNotes.txt", System.Text.Encoding.GetEncoding(1251)))
            {
                string notes;
                var resultNote = new StringBuilder();
                while (readerFirst.EndOfStream != true)
                {
                    notes = readerFirst.ReadLine();
                    resultNote.AppendLine(notes);
                }
                FormMyNotes fMyNotes = new FormMyNotes();
                fMyNotes.textBoxMyNotes.Text = resultNote.ToString();
                fMyNotes.Show();
            }
        }

        /// <summary>
        /// Кнопка вызова формы справочника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormHelp formFirst = new FormHelp();
            formFirst.Show();
        }

        /// <summary>
        /// Кнопка выхода из программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
