using Goldenriff.Domain.Common;

namespace Goldenriff.Domain.Entities
{
    public class Brand : BaseEntity
    {
        public string Name { get; set; } = default!;
        public string? Description { get; set; }

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
