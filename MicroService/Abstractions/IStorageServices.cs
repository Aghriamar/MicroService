using MicroService.Models.Dto;

namespace MicroService.Abstractions
{
    public interface IStorageServices
    {
        IEnumerable<StorageDto> GetStorages();
        int AddStorage(StorageDto storage);
    }
}
