using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectT1.DictionaryAPI.Infrastructure.Services {
    public interface ICRUDCategoryService<T> {
        Task<(IEnumerable<T> Result, int Code, string Message)> GetAll();
        Task<(T Result, int Code, string Message)> GetById(Guid id);
        Task<(IEnumerable<T> Result, int Code, string Message)> Post(IEnumerable<T> dataSource);
        Task<(T Result, int Code, string Message)> Put(T objSource, Guid id);
        Task<(Guid? Result, int Code, string Message)> Delete(Guid id);
    }

    public interface ICRUDFunctionService<T> {
        Task<(IEnumerable<T> Result, int Code, string Message)> GetAll();
        Task<(T Result, int Code, string Message)> GetById(Guid id);
        Task<(IEnumerable<T> Result, int Code, string Message)> Post(IEnumerable<T> dataSource);
        Task<(T Result, int Code, string Message)> Put(T objSource, Guid id);
        Task<(Guid? Result, int Code, string Message)> Delete(Guid id);
    }
}