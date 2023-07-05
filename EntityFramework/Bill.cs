using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyCafe.EntityFramework
{
    [Table("Bill")]
    public class Bill
    {
        public int Id { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime DateOut { get; set; }
        public int TableId { get; set; }
        public Table Table { get; set; }
        public Status Status { get; set; }
        public decimal TotalPrice { get; set; }
        public List<BillInfo> BillInfos { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
    }
}
