using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyCafe.EntityFramework
{
    [Table("AreaTable")]
    public class AreaTable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationTime { get; set; } = DateTime.Now;
        public Status Status { get; set; }
        public List<Table> Tables { get; set; }
    }
}
