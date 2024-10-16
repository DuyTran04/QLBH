using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.Models
{
    internal class Employee
    {
        public Employee()
        {
            this.Orders = new HashSet<Order>();
        }
        public long EmployeeID { get; set; }
        [StringLength(100)]
        public string EmployeeName { get; set; }
        public bool? Gender { get; set; }
        [Column(TypeName = "Date")]
        public DateTime BirthDay { get; set; }
        [StringLength(250)]
        public string Address { get; set; }
        [StringLength(10, MinimumLength = 10), Column(TypeName = "nchar(10)")]
        public string Phone { get; set; }
        [DataType(DataType.EmailAddress)]
        [StringLength(100)]
        public string? Email { get; set; }
        public bool Status { get; set; }
        [StringLength(6)]
        public string Password { get; set; }
        public byte RoleID { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }

}
