using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_1214074
{
    public class Product_1214074
    {
        //protected string myType = "Buku";
        private string myType;
        private string myTitle;

        public Product_1214074()
        {

        }

        public Product_1214074(string type, string title) // Method Constructor (Parameter)
        {
            this.myType = type;
            this.myTitle = title;
        }

        public string MyType
        {
            get
            {
                return myType;
            }
            set
            {
                myType = value;
            }
        }

        public string MyTitle
        {
            get
            {
                return myTitle;
            }
            set
            {
               myTitle = value;
            }
        }
    }
}
