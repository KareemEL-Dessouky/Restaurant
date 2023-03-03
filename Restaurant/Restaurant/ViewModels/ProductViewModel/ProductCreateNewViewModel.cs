using Restaurant.Models;

namespace Restaurant.ViewModels.ProductViewModel;

public class ProductCreateNewViewModel
{
    // product name
    public string Title { get; set; } = null!;
    public decimal Price { get; set; }
    public IFormFile? Image { get; set; }
    public int CategoryID { get; set; }
    public IEnumerable<Category> Categories { get; set; } = null!;

}