using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bursty.Service
{
    class Log
    {
        private int id;
        private string name;
        private int frequency;
        private Nullable<double> lastLine;
        private string path;
        private System.ComponentModel.BindingList<Check> checks = new System.ComponentModel.BindingList<Check>();

        public Log(string name, string path)
        {
            this.name = name;
            this.path = path;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Path { get => path; set => path = value; }
        public int Frequency { get => frequency; set => frequency = value; }
        public double? LastLine { get => lastLine; set => lastLine = value; }
        internal BindingList<Check> Checks { get => checks; set => checks = value; }
    }
}
