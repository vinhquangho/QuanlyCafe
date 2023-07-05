using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyCafe.EntityFramework
{
    [Table("Table")]
    public class Table
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationTime { get; set; } = DateTime.Now;
        public Status Status { get; set; }
        public int AreaTableId { get; set; }
        public AreaTable AreaTable { get; set; }
    }
}
