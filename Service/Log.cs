using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bursty.Service
{
    class Log
    {
        private int id;
        private string name;
        private string path;

        public Log(string name, string path)
        {
            this.name = name;
            this.path = path;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Path { get => path; set => path = value; }
    }
}
