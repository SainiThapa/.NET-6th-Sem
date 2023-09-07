using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace RestaurantWebOrder.Models.Domain
{
    public class Order
    {
        [Required]
        public Guid OrderId { get; set; }
        public string CustomerName { get; set; }

        public string ItemType { get; set; }
        public string ItemName { get; set; }

        public decimal Total { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }

    }
}
