namespace ATTicket.Domain.Dtos;
public sealed class ProductModuleDto : Entity
{
    public int ProductId { get; set; }
    public string? ProductModuleName { get; set; }
}