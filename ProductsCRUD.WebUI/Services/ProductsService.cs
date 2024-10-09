using Microsoft.EntityFrameworkCore;
using ProductsCRUD.WebUI.Abstractions;
using ProductsCRUD.WebUI.Data;
using ProductsCRUD.WebUI.Models;

namespace ProductsCRUD.WebUI.Services
{
    public class ProductsService : IProductsService
    {
        private readonly DatabaseContext _context;

        public ProductsService(DatabaseContext context) => _context = context;

        public async Task UpdateAsync(ProductEntity input)
        {
            _context.Products.Update(input);
            await _context.SaveChangesAsync();
        }

        public async Task<int> CountItemsAsync()
        {
            return await _context.Products.CountAsync();
        }

        public async Task<IEnumerable<ProductEntity>> GetProductsAsync(int page)
        {
            int limit = 10;

            return await _context.Products
                .Skip((page - 1) * limit)
                .Take(limit)
                .ToListAsync();
        }

        public async Task<ProductEntity?> GetProductsAsync(Guid id)
        {
            return await _context.Products
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task SaveOneAsync(ProductEntity input)
        {
            await _context.Products.AddAsync(input);
            await _context.SaveChangesAsync();
        }
    }
}
