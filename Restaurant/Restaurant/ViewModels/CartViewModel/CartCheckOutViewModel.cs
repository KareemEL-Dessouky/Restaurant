namespace Restaurant.ViewModels.CartViewModel;

public class CartCheckOutViewModel
{
    // User action flow to checkout:
    // Add to cart(one or many items) => view cart details => checkout
    // Where OrderDetail view has the total price?, customer name, createdOn date & list of Cart Items 
    public int Id { get; set; }
    public DateTime OrderCreated { get; set; }
    public string CustomerFullName { get; set; } = null!;
    public string ItemName { get; set; }
    public decimal TotalPrice { get; set; }
    public string? OrderNotes { get; set; }
    public IEnumerable<CartItemViewModel> AllOrderItems { get; set; } = new List<CartItemViewModel>();
}

