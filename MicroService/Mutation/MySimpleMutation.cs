using MicroService.Abstractions;
using MicroService.Models.Dto;

namespace MicroService.Mutation
{
    public class MySimpleMutation
    {
        public int AddProduct([Service] IProductServices services, ProductDto product)
        {
            var id = services.AddProduct(product);
            return id;
        }

        public int AddStorages([Service] IStorageServices services, StorageDto storage)
        {
            var id = services.AddStorage(storage);
            return id;
        }

        public int AddCategory([Service] ICategoryServices services, CategoryDto category)
        {
            var id = services.AddCategory(category);
            return id;
        }
    }
}
