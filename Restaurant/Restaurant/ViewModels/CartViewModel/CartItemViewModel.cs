namespace Restaurant.ViewModels.CartViewModel;
public class CartItemViewModel
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    // calculate total price for an item
    public decimal ItemsTotalPrice { get { return Price * Quantity; } }
}
