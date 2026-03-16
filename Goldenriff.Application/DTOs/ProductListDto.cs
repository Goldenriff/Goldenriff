namespace Goldenriff.Application.DTOs
{
    public class ProductListDto
    {
        public string Name { get; set; } = default!;
        public decimal Price { get; set; }
        public string? ThumbnailUrl { get; set; }
        public bool IsInStock { get; set; }
    }
}
