using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bursty.Presentation
{
    public partial class LogList : Form
    {
        public LogList()
        {
            InitializeComponent();
        }

        private void LogList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bursty.Logs' table. You can move, or remove it, as needed.
            this.logsTableAdapter.Fill(this.bursty.Logs);

        }
    }
}
