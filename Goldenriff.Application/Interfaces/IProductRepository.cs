using Goldenriff.Domain.Entities; // Change this to the actual namespace where Product is defined

namespace Goldenriff.Application.Interfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> GetActiveProductsAsync();
    }
}
