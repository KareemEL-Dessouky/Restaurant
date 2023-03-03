namespace Restaurant.ViewModels;

public class FavoriteItemsViewModel
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
    public string? ImageUrl { get; set; }
}

