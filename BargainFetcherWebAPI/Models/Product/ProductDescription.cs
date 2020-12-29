using System.Collections.Generic;

namespace BargainFetcher.Models
{
    public class ProductDescription
    {
        public int ProductDescriptionID { get; set; }
        public string Text { get; set; }
        public string[] ImagesURI { get; set; }
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
    }
}