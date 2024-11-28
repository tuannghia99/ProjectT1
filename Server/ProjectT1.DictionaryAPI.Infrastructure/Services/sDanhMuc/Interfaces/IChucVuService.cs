using ProjectT1.DictionaryAPI.Infrastructure.DTOs;

namespace ProjectT1.DictionaryAPI.Infrastructure.Services {
    public interface IChucVuService : ICategoryService, ICRUDCategoryService<ChucVuDTO> {
    }
}