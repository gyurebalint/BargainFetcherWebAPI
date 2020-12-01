using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BargainFetcher.Dtos
{
    public class ProductCreateDto
    {
        public string ProductCode { get; set; }
        public string Title { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int OldPrice { get; set; }
        public int NewPrice { get; set; }
        public int Sale { get; set; }
        public int NumberOfReviews { get; set; }

        //This prop was of type decimal
        public double StarsAverage { get; set; }
        // public string Link { get; set; }
        // public ProductDescription Description { get; set; }
        // public List<ProductDetail> Details { get; set; }
        // public List<ProductReview> Reviews { get; set; }
        // public List<ProductImage> Images { get; set; }

        // public override string ToString()
        // {
        //     return $" Product ID : {ProductID}\n Product Code : {ProductCode}\n Brand : {Brand} \n Model : {Model} \n" +
        //         $" Old Price : {OldPrice} \n New price : {NewPrice} \n Sale : {Sale} \n Number of reviews : {NumberOfReviews} \n" +
        //         $" Average star reating : {StarsAverage} \n Title : {Title} \n Link : {Link}\n \n";
        // }
    }
}