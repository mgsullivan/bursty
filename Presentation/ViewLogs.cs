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
    public partial class ViewLogs : Form
    {
        public ViewLogs()
        {
            InitializeComponent();
        }
        private void LoadLogs(Log currentLog)
        {
            BurstyDataSet.LogsDataTable logsDataTable = logsTableAdapter1.GetData();
            foreach (BurstyDataSet.LogsRow logRow in logsDataTable)
            {

            }
        }
    }
   
}
