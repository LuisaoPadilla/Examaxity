using ExamaxityApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamaxityApp.Services
{
    public class ProductsRepository : IProductsRepository
    {
        private AppDbContext dbContext;

        public ProductsRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<Products>> GetProducts()
        {
            return await dbContext.Products.ToListAsync();
        }
    }
}
