using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bursty.Presentation
{
    
    class Line
    {
        private int id;
        private double number;
        private int check;
        public int Id
        {
            get { return id;
            }
            set { id = value; }
        }
        public double Number
        {
            get { return number; }
            set { number = value; }
        }
        public int Check
        {
            get { return check; }
            set { check = value; }
        }

        public Line(double number,int check)
        {
            this.number = number;
            this.check = check;
        }
        
    }
}
