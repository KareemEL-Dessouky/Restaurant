using System.ComponentModel.DataAnnotations;

namespace Restaurant.ViewModels.ProductViewModel;

public class ProductViewModel
{
    public int ID { get; set; }

    // product Name (left for automapper)
    [Required]
    [Display(Name = "Product:")]
    [StringLength(50, ErrorMessage = "Product name must be at most {1} characters long")]
    public string Title { get; set; } = null!;

    [Required(ErrorMessage = "The price is required")]
    [DataType(DataType.Currency)]
    public decimal Price { get; set; }

    public IFormFile? Image { get; set; }


    [Required(ErrorMessage = "Choose a product category")]
    public int CategoryID { get; set; }

    // exluded for model state

    //public string Category { get; set; } = null!;

    // exluded for model state, require another view model
    //public IEnumerable<Category> Categories { get; set; } = null!;

}
