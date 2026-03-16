using Goldenriff.Domain.Common;

namespace Goldenriff.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; } = default!;
        public string? Description { get; set; }

        public int? ParentCategoryId { get; set; }
        public Category? ParentCategory { get; set; }

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
