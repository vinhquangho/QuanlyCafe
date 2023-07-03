using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyCafe.EntityFramework
{
    [Table("BillInfo")]
    public class BillInfo
    {
        public int Id { get; set; }
        public int BillId { get; set; }
        public Bill Bill { get; set; }
        public int FoodId { get; set; }
        public Food Food { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
    }
}
