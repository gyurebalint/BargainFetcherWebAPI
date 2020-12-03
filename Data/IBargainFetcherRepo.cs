using System.Collections.Generic;
using BargainFetcher.Models;

namespace BargainFetcher.Data
{
    public interface IBargainFetcherRepo
    {
        bool SaveChanges();
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id);
        void CreateProduct(Product product);
        void UpdateProducts(Product product);
        void DeleteProduct(Product product);
    }
}