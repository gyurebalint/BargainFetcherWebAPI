using System.Collections.Generic;
using BargainFetcher.Models;

namespace BargainFetcher.Data
{
    public class MockBargainFetcherRepo : IBargainFetcherRepo
    {
        public void CreateProduct()
        {
            throw new System.NotImplementedException();
        }

        public void CreateProduct(Product product)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteProduct(Product product)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            var products = new List<Product>
            {
                new Product
                {
                    ProductID = 1,
                    ProductCode = "YXCASDQWE 56",
                    Title = "This is the product page's title",
                    Brand = "Samsung",
                    Model="XSD 80",
                    OldPrice = 150000,
                    NewPrice = 100000,
                    Sale = 33,
                    NumberOfReviews = 44,
                    StarsAverage = 4.6,
                    Link = "https\\:www.google.com"
                },

            new Product
            {
                ProductID = 2,
                ProductCode = "YXCASDQWE 56",
                Title = "This is the product page's title 2",
                Brand = "LG",
                Model = "XSD 80",
                OldPrice = 200000,
                NewPrice = 150000,
                Sale = 25,
                NumberOfReviews = 30,
                StarsAverage = 3.3,
                Link = "https\\:www.google.com"
            },

            new Product
            {
                ProductID = 3,
                ProductCode = "YXCASDQWE 56",
                Title = "This is the product page's title 3",
                Brand = "Sony",
                Model = "XSD 80",
                OldPrice = 250000,
                NewPrice = 200000,
                Sale = 20,
                NumberOfReviews = 40,
                StarsAverage = 2.2,
                Link = "https\\:www.google.com",
                Description = new ProductDescription
                {
                    Text = "This is the productDescription"
                },
                Details = new List<ProductDetail> {new ProductDetail{Title = "Képátmérő", Text = "106"}, new ProductDetail{Title = "Operációs rendszer", Text = "Android"}}
            }         
        };

            return products;
        }

        public Product GetProductById(int id)
        {
            return new Product
            {
                ProductID = 1,
                ProductCode = "YXCASDQWE 56",
                Title = "This is the product page's title",
                Brand = "Samsung",
                Model = "XSD 80",
                OldPrice = 150000,
                NewPrice = 100000,
                Sale = 33,
                NumberOfReviews = 44,
                StarsAverage = 4.6,
                Link = "https\\:www.google.com"
            };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateProducts(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}