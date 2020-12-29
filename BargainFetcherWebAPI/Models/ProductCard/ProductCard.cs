using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BargainFetcher.Models
{
    public class ProductCard
    {
        string ItemName { get; set; }
        string ItemUrl { get; set; }
        bool Discounted { get; set; }
        decimal CurrentPrice { get; set; }
        decimal OldPrice { get; set; }
        string Img { get; set; }
    }
}