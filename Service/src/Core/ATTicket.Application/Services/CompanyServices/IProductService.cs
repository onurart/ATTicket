using ATTicket.Application.Features.CompanyFeatures.Product.Commands.Create;

namespace ATTicket.Application.Services.CompanyServices;
public interface IProductService
{
    Task<IList<Product>> GetAllAsync(string companyId);
    Task<Product> GetByIdAsync(string id, string companyId);
    Task<Product> CreateProductAsync(CreateProductCommand request, CancellationToken cancellationToken);
    Task<Product> RemoveByIdProductAsync(string id, string companyId);
    Task UpdateAsync(Product product, string companyId);
}
