using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyCafe.EntityFramework
{
    [Table("Food")]
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime CreationTime { get; set; } = DateTime.Now;
        public Status Status { get; set; }
        public int CategoryId { get; set; }
        //public Category Category { get; set; }
    }
}
