using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BargainFetcher.Models.WebshopLinks
{
    public class LeafCategory
    {
        public int Id { get; set; }
        public string LeafCategoryName { get; set; }
        public string LeafCategoryLink { get; set; }
        public string CategoryName { get; set; }
        public string CategoryLink { get; set; }
        public string WebshopName { get; set; }
        public string WebshopLink { get; set; }
    }
}