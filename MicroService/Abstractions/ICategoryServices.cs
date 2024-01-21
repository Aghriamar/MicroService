using MicroService.Models.Dto;

namespace MicroService.Abstractions
{
    public interface ICategoryServices
    {
        IEnumerable<CategoryDto> GetCategories();
        int AddCategory(CategoryDto category);
    }
}
