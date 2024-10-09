using ProductsCRUD.WebUI.Models;

namespace ProductsCRUD.WebUI.Abstractions
{
    public interface IProductsService
    {
        Task<IEnumerable<ProductEntity>> GetProductsAsync(int page);
        Task<ProductEntity?> GetProductsAsync(Guid id);
        Task SaveOneAsync(ProductEntity input);
        Task UpdateAsync(ProductEntity input);
        Task DeleteAsync(ProductEntity input);
        Task<int> CountItemsAsync();
    }
}
