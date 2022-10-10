using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_1214074
{
    internal class DVD_1214074 : Product_1214074
    {
        protected string duration;

        public DVD_1214074 (string title, string duration) // Method constructor dengan 2 parameter
        {
            this.MyTitle = title;
            this.MyType = "DVD";
            this.duration = duration;

            Console.WriteLine("Ini dari class DVD!!!");
        }

        public string Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }
    }
}
