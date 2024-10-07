using ProductsCRUD.WebUI.Models;

namespace ProductsCRUD.WebUI.Abstractions
{
    public interface IProductsService
    {
        Task<IEnumerable<ProductEntity>> GetProductsAsync();
        Task SaveOneAsync(ProductEntity input);
    }
}
