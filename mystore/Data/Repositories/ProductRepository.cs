using Microsoft.EntityFrameworkCore;
using mystore.Data.Interfaces;
using mystore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mystore.Data.Repositories
{
    public class ProductRepository:IProductRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public ProductRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Product> Products => _appDbContext.Products.Include(c => c.Category);

        public IEnumerable<Product> PreferredProducts => _appDbContext.Products.Where(p => p.IsPreferredProduct).Include(c => c.Category);

        public Product GetProductById(int productId) => _appDbContext.Products.FirstOrDefault(p => p.ProductId == productId);
    }
}
