using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.Models
{
    internal class Customer
    {
        public Customer()
        {
            this.Orders = new HashSet<Order>();
        }

        public long CustomerID { get; set; } //bigint, identity(1,1), PK
        [StringLength(100)]
        public string CustomerName { get; set; } //nvarchar(100), not null
        public bool? Gender { get; set; } //bit, null
        [Column(TypeName = "Date")]
        public DateTime BirthDay { get; set; }
        [StringLength(250)]
        public string Address { get; set; }
        [StringLength(10, MinimumLength = 10), Column(TypeName = "nchar(10)")]
        public string Phone { get; set; } 
        [DataType(DataType.EmailAddress)]
        [StringLength(100)]
        public string? Email { get; set; }
        public bool Status { get; set; } //bit, not null

        //[InverseProperty("Customer")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
