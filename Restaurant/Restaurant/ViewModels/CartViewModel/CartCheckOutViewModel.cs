namespace Restaurant.ViewModels.CartViewModel;

public class CartCheckOutViewModel
{
    public string CustomerName { get; set; } = null!;
    public decimal TotalPrice { get; set; }
    public string? OrderNotes { get; set; }
    public string ProductItem { get; set; } = null!;
    public int Quantity { get; set; }
    public IEnumerable<CartItemViewModel> OrderItems { get; set; } = new List<CartItemViewModel>();
}

