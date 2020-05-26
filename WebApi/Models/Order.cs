using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string OrderNo { get; set; }

        public int CustomerId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string PMethod { get; set; }

        public double GTotal { get; set; }

        public Customer Customer { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
