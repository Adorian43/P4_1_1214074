using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace P4_1_1214074
{
    internal class Book_1214074 : Product_1214074
    {
        protected string pageCount; 

        public Book_1214074(string type, string title, string pageCount) : base(type, title)
        {
            this.pageCount = pageCount;
        }

        public string PageCount
        {
            get { return pageCount; }
            set { pageCount = value; }  
        }
    }
}
