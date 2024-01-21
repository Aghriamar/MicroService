using MicroService.Abstractions;
using MicroService.Models.Dto;

namespace MicroService.Query
{
    public class MySimpleQuery
    {
        public IEnumerable<ProductDto> GetProducts([Service] IProductServices services) => services.GetProducts();
        public IEnumerable<StorageDto> GetStorages([Service] IStorageServices services) => services.GetStorages();
        public IEnumerable<CategoryDto> GetCategories([Service] ICategoryServices services) => services.GetCategories();
    }
}
