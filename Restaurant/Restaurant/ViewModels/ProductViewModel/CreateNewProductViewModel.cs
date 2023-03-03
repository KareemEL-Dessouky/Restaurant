namespace Restaurant.ViewModels.ProductViewModel;

public class ProductInfoViewModel
{
    // product name
    public string Title { get; set; } = null!;
    public decimal Price { get; set; }
    public string? Image { get; set; }

    // for categories list values (temp solution)
    public IEnumerable<int> CategoriesIds { get; set; } = null!;
    // for categories list names
    public IEnumerable<string> CategoriesNames { get; set; } = null!;

}
