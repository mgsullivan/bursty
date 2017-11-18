using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bursty.Service
{
    class Check
    {
        private int id;
        private string pattern;
        private int frequency;
        private Nullable<DateTime> lastCheck;
        private bool repeat;
        private bool hit;
        private int lineVolume;
        private System.ComponentModel.BindingList<Line> lines = new System.ComponentModel.BindingList<Line>();

        public Check()
        {


        }

        public Check(string pattern, int frequency, bool repeat)
        {
            this.pattern = pattern;
            this.frequency = frequency;
            this.repeat = repeat;
            lineVolume = 1;
            hit = false;
            lastCheck = null;
            

        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Pattern
        {
            get { return pattern; }
            set { pattern = value; }
        }
        public int Frequency
        {
            get { return frequency; }
            set { frequency = value; }
        }
        public bool Repeat
        {
            get { return repeat; }
            set { repeat = value; }
        }
        public Nullable<DateTime> LastCheck
        {
            get { return lastCheck;
            }
            set { lastCheck = value; }
        }

        public int LineVolume { get => lineVolume; set => lineVolume = value; }
        internal BindingList<Line> Lines { get => lines; set => lines = value; }

        
    }
    
}
