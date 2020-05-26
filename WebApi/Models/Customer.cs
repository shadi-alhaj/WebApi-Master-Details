using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string Name { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
