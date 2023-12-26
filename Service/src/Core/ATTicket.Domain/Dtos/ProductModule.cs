namespace ATTicket.Domain.Dtos;
public sealed class ProductModule : Entity
{
    public int ProductId { get; set; }
    public string? ProductModuleName { get; set; }
}