using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyCafe.EntityFramework
{
    public class Report
    {
        public string DateIn { get; set; }
        public string DateOut { get; set; }
        public string TableName { get; set; }
        public string Status { get; set; }
        public string Price { get; set; }
        public string TotalPrice { get; set; }
        public string Discount { get; set; }
        public string Service { get; set; }
        public string Note { get; set; }
        public string AccountName { get; set; }
    }
}
