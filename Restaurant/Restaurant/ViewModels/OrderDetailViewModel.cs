public class OrderDetailViewModel
{
    // User action flow to checkout:
    // Add to cart(one or many items) => view cart details => checkout
    // Where OrderDetail view is optional
    // User can perform add to cart action then checkout
    public int Id { get; set; }
    public DateTime OrderCreated { get; set; }
    public string CustomerFullName { get; set; } = null!;
    public string? OrderNotes { get; set; }
    public decimal TotalAmount { get; set; }
    public IEnumerable<OneOrderViewModel> AllOrderItems { get; set; } = null!;

}

