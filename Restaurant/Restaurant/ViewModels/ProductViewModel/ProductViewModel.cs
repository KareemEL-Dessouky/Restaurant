namespace Restaurant.ViewModels.ProductViewModel;

public class ProductViewModel
{
    public int ID { get; set; }
    public string Title { get; set; } = null!;
    public decimal Price { get; set; }
    public string? Image { get; set; }

}
