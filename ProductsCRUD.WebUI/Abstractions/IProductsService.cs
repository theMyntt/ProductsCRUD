using ProductsCRUD.WebUI.Models;

namespace ProductsCRUD.WebUI.Abstractions
{
    public interface IProductsService
    {
        Task<IEnumerable<ProductEntity>> GetProductsAsync(int page);
        Task SaveOneAsync(ProductEntity input);
        Task UpdateAsync(ProductEntity input);
        Task<int> CountItemsAsync();
    }
}
