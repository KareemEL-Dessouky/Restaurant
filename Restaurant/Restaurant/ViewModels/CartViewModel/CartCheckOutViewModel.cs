namespace Restaurant.ViewModels.CartViewModel;

public class CartCheckOutViewModel
{
    public string CustomerName { get; set; } = null!;
    public string? OrderNotes { get; set; }
    public CartItemViewModel CartItem { get; set; } = null!;
}

