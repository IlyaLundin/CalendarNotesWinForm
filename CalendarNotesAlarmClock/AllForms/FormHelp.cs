using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarNotesAlarmClock
{
    /// <summary>
    /// Форма справки
    /// </summary>
    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Кнопка закрытия формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
