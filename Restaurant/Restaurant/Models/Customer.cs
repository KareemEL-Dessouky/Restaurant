using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Models
{
    public class Customer
    {
        public int ID { get; set; }

        //[ForeignKey("Orders")]
        //public int OrderID { get; set; }

        public string Username { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string? Address { get; set; }

        public string Password { get; set; }

        public string? Img { get; set; }

        public List<Order> Orders { get; set; }


    }
}
