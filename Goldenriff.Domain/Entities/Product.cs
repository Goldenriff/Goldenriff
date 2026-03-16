using Goldenriff.Domain.Common;

namespace Goldenriff.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; } = default!;
        public string Slug { get; set; } = default!; // SEO dostu URL (örn: fender-player-strat)
        public string Sku { get; set; } = default!; // Ürün stok kodu

        public decimal Price { get; set; }
        public decimal? OldPrice { get; set; } // indirimsiz fiyat

        public int StockQuantity { get; set; }
        public string? Condition { get; set; } // "New", "Used", "B-Stock" gibi

        public int BrandId { get; set; }
        public Brand Brand { get; set; } = default!;

        public int CategoryId { get; set; }
        public Category Category { get; set; } = default!;

        public string? ThumbnailUrl { get; set; }
        public string? Description { get; set; }

        public bool IsActive { get; set; } = true;

        public bool IsInStock => StockQuantity > 0 && IsActive;


    }
}
