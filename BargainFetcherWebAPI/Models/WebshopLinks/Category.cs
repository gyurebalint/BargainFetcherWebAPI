using System.Collections.Generic;

namespace BargainFetcher.Models.WebshopLinks
{
    internal class Category
    {
        string CategoryName { get; set; }
        string CategoryLink { get; set; }
        List<SubCategory> subCategories { get; set; }
    }
}