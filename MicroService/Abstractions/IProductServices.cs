using MicroService.Models.Dto;

namespace MicroService.Abstractions
{
    public interface IProductServices
    {
        IEnumerable<ProductDto> GetProducts();
        int AddProduct(ProductDto product);
    }
}
