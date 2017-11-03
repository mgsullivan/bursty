using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class ManageLogs : Form
    {
        public ManageLogs()
        {
            InitializeComponent();
        }

        private void logsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.logsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bursty_dbDataSet);

        }

        private void logsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.logsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bursty_dbDataSet);

        }
    }
}
