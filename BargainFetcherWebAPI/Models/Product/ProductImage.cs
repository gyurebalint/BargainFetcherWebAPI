namespace BargainFetcher.Models
{
    public class ProductImage
    {
        public int ProductImageID { get; set; }
        public string ImageURI { get; set; }
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }

        public override string ToString()
        {
            return $"       ProductImageID : {ProductImageID} \n        ImageURI : {ImageURI} \n";
        }
    }
}