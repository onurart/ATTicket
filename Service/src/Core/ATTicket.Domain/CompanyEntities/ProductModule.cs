namespace ATTicket.Domain.CompanyEntities;

public sealed class ProductModule : Entity
{
    [ForeignKey("Product")]
    public int ProductId { get; set; }
    public Product Product { get; set; }
    public string? ProductModuleName { get; set; }
}