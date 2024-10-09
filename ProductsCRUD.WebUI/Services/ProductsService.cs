﻿using Microsoft.EntityFrameworkCore;
using ProductsCRUD.WebUI.Abstractions;
using ProductsCRUD.WebUI.Data;
using ProductsCRUD.WebUI.Models;

namespace ProductsCRUD.WebUI.Services
{
    public class ProductsService : IProductsService
    {
        private readonly DatabaseContext _context;

        public ProductsService(DatabaseContext context) => _context = context;

        public async Task<IEnumerable<ProductEntity>> GetProductsAsync(int page)
        {
            int limit = 10;

            return await _context.Products
                .Skip((page - 1) * limit)
                .Take(limit)
                .ToListAsync();
        }

        public async Task SaveOneAsync(ProductEntity input)
        {
            await _context.Products.AddAsync(input);
            await _context.SaveChangesAsync();
        }
    }
}
