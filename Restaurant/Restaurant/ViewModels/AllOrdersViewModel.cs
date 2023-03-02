public class AllOrdersViewModel
{
    public int Id { get; set; }
    public decimal TotalPrice { get; set; }
    public DateTime OrderedAt { get; set; }
    public string? Notes { get; set; } = null!;
    public IEnumerable<OneOrderViewModel> OrderItems { get; set; } = null!;
}
