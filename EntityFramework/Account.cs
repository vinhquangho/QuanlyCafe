using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public DateTime CreationTime { get; set; } = DateTime.Now;
        public Status Status { get; set; }
        public List<Bill> Bills { get; set; }
    }
    public enum Status
    {
        [Display(Name = "Đang hoạt động")]
        Active = 1,
        [Display(Name = "Ngừng hoạt động")]
        DeActive = 2,
    }
}
