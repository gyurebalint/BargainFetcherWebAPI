using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BargainFetcher.Models.WebshopLinks
{
    public class WebshopLink
    {
        string WebshopName { get; set; }
        string WebshopsLink { get; set; }
        List<Category> categories { get; set; }
    }
}