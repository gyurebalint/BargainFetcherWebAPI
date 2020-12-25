using System;
using System.Collections.Generic;
using System.Linq;
using BargainFetcher.Models;
using Microsoft.EntityFrameworkCore;

namespace BargainFetcher.Data
{
    public class SqlBargainFetcherRepo : IBargainFetcherRepo
    {
        private readonly BargainFetcherContext _context;

        public SqlBargainFetcherRepo(BargainFetcherContext context)
        {
            _context = context;
        }


        public void CreateProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }
            _context.Products.Add(product);
        }

        public void DeleteProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }
            _context.Products.Remove(product);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products
            .Include(x => x.Reviews)
            .Include(y => y.Details)
            .Include(z => z.Images)
            .Include(u => u.Description)
            .AsSplitQuery()
            .ToList();
        }

        public Product GetProductById(int id)
        {
            return _context.Products
            .Include(x => x.Reviews)
            .Include(y => y.Details)
            .Include(z => z.Images)
            .Include(u => u.Description)
            .AsSplitQuery()
            .FirstOrDefault(predicate => predicate.ProductID == id);
            //FirstOrDefault(predicate => predicate.ProductID == id);//.Include(y => y.Details).Include(z => z.Images).Include(u => u.Description).AsSplitQuery().FirstOrDefault(predicate => predicate.ProductID == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges()) >= 0;
        }

        public void UpdateProducts(Product product)
        {
            //Nothing
        }
    }
}