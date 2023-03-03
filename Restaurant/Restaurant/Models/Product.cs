using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Models
{
    public class Product
    {
        public int ID { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }

        public string? Image { get; set; }

        public Category Category { get; set; }

        public List<OrderItems> Items { get; set; }

    }
}
