using Goldenriff.Application.DTOs;

namespace Goldenriff.Application.Interfaces
{
    public interface IProductService
    {
        Task<List<ProductListDto>> GetActiveProductsAsync();
    }
}
