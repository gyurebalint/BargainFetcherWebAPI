using System;
using System.Collections.Generic;
using System.Linq;
using BargainFetcher.Models;

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
            return _context.Products.ToList();
        }

        public Product GetProductById(int id)
        {
            return _context.Products.FirstOrDefault(predicate => predicate.ProductID == id);
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