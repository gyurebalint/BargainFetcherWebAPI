using System;
using BargainFetcher.Models;
using BargainFetcher.Models.WebshopLinks;
using Microsoft.EntityFrameworkCore;

namespace BargainFetcher.Data
{
    public class BargainFetcherContext : DbContext
    {
        public BargainFetcherContext(DbContextOptions<BargainFetcherContext> opt) : base(opt)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDescription> ProductDescriptions { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<ProductReview> ProductReviews { get; set; }



        public DbSet<LeafCategory> LeafCategories { get; set; }


        /*
        The property 'ImagesURI.ProductDescription' is a collection or enumeration type with a value converter but with no value comparer. 
        Set a value comparer to ensure the collection/enumeration elements are compared correctly.
        */

        /* In EF we can only use primitive types for SQL columns. So if we wanna use sth different, such as a string array,
        when uploading/downloading from SQL we have to alter it to be primitive.
        */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductDescription>()
                .Property(e => e.ImagesURI)
                .HasConversion(
                v => string.Join(',', v),
                v => v.Split(',', StringSplitOptions.RemoveEmptyEntries));
        }
    }
}