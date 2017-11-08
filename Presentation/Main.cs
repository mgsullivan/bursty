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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("Bursty.Service.exe");
        }
    }
}
