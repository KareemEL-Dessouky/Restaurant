using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Models
{
    public class Order
    {
        public int ID { get; set; }

        public int TotalPrice { get; set; }

        public DateTime? PlacedAt { get; set; }

        [ForeignKey("Customer")]
        public int CustomerID { get; set; }

        public string? Notes { get; set; }

        public Customer Customer { get; set; }

        public List<OrderItems> Products { get; set; }
    }
}
