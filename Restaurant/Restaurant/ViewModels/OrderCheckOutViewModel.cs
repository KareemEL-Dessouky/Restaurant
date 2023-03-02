public class OrderCheckOutViewModel
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalPrice { get; set; }
    public OrderDetailViewModel OrderDetailViewModel { get; set; } = null!;
}
    
