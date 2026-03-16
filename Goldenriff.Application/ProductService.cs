using Goldenriff.Application.DTOs;
using Goldenriff.Application.Interfaces;

namespace Goldenriff.Application
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<ProductListDto>> GetActiveProductsAsync()
        {
            var products = await _productRepository.GetActiveProductsAsync();

            var result = products
                .Where(p => !p.IsDeleted && p.IsActive)
                .Select(p => new ProductListDto
                {
                    Name = p.Name,
                    Price = p.Price,
                    ThumbnailUrl = p.ThumbnailUrl,
                    IsInStock = p.IsInStock,
                })
                .ToList();

            return result;
        }



    }
}
