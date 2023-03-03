namespace Restaurant.ViewModels.ProductViewModel;

public class ProductCreateNewViewModel
{
    // product name
    public string Title { get; set; } = null!;
    public decimal Price { get; set; }
    public IFormFile? Image { get; set; }
    public IEnumerable<string> SelectedCategories { get; set; } = null!;

}