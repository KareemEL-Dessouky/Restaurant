using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Models
{
    public class OrderItems
    {
        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public int OrderID { get; set; }

        public int ProductID { get; set; }

        public Product Product { get; set; }

        public Order Order { get; set; }


        
    }
}
