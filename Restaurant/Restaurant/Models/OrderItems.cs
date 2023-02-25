using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Models
{
    public class OrderItems
    {
        public int Price { get; set; }

        public int Quantity { get; set; }

        //[ForeignKey("Order")]
        //[Key, Column(Order = 0)]
        public int OrderID { get; set; }

        //[ForeignKey("Product")]
        //[Key, Column(Order = 1)]
        public int ProductID { get; set; }

        public Product Product { get; set; }

        public Order Order { get; set; }


        
    }
}
