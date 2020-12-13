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

    }
}