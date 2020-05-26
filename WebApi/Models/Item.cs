using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Item
    {
        public int ItemId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        public double Price { get; set; }

        public virtual ICollection<OrderItem> GetOrderItems { get; set; }

    }
}
