using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Properties;

namespace Bursty.Presentation
{
    public partial class Main : Form
    {
        private List<Check> checks;
        private List<Line> lines;
        private List<Log> logs;
        private Check selectedCheck;
        private Line selectedLine;
        private Log selectedLog;

        public Main()
        {
            using (var db = new BurstyDataContext())
            {
                checks = db.Checks.ToList();
                lines = db.Lines.ToList();
                logs = db.Logs.ToList();
            }
            refreshListItems();
            InitializeComponent();

        }
        private void refreshListItems()
        {

            refreshLogItems();
            refreshCheckItems();
            refreshListItems();      

        }
        private void refreshLogItems()
        {
            for (int i = 0; i < logs.Count; i++)
            {
                listBoxLogs.Items.Add(logs[i].Name);
            }
        }
        private void refreshLineItems()
        {
            for (int i = 0; i < lines.Count; i++)
            {
                listBoxLogs.Items.Add(lines[i].Number);
            }
        }
        private void refreshCheckItems()
        {
            for (int i = 0; i < checks.Count; i++)
            {
                listBoxChecks.Items.Add(checks[i].Pattern);
            }
        }
    }
}
