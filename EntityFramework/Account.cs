using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyCafe.EntityFramework
{
    [Table("Account")]
    public class Account
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string DislayName { get; set; }
        public DateTime CreationTime { get; set; }
        public Status Status { get; set; }
    }
    public enum Status
    {
        Active = 1,
        DeActive = 2,
    }
}
