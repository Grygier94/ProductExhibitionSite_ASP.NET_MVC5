﻿using GrygierSite.Models;
using System;

namespace GrygierSite.ViewModels
{
    public class DetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateOfIssue { get; set; }
        public DateTime LastUpdate { get; set; }
        public string MarketUrl { get; set; }
        public decimal Price { get; set; }
        public string ThumbnailPath { get; set; }
        public Category Category { get; set; }
        public bool AuthenticatedUser { get; set; }

        public DetailsViewModel(Product product)
        {
            Id = product.Id;
            Category = product.Category;
            DateOfIssue = product.DateOfIssue;
            Description = product.Description;
            LastUpdate = product.LastUpdate;
            MarketUrl = product.MarketUrl;
            Name = product.Name;
            Price = product.Price;
            ThumbnailPath = product.ThumbnailPath;
        }
    }
}