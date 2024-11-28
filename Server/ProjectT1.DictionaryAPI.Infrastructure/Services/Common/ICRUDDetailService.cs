using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectT1.DictionaryAPI.Infrastructure.Services {
    public interface ICRUDCategoryDetailService<T> {
        Task<(IEnumerable<T> Result, int Code, string Message)> GetAll(Guid idCha);
        Task<(T Result, int Code, string Message)> GetById(Guid idCha, Guid id);
        Task<(IEnumerable<T> Result, int Code, string Message)> Post(Guid idCha, IEnumerable<T> dataSource);
        Task<(T Result, int Code, string Message)> Put(Guid idCha, T objSource, Guid id);
        Task<(Guid? Result, int Code, string Message)> Delete(Guid idCha, Guid id);
    }

    public interface ICRUDFunctionDetailService<T> {
        Task<(IEnumerable<T> Result, int Code, string Message)> GetAll(Guid idCha);
        Task<(T Result, int Code, string Message)> GetById(Guid idCha, Guid id);
        Task<(IEnumerable<T> Result, int Code, string Message)> Post(Guid idCha, IEnumerable<T> dataSource);
        Task<(T Result, int Code, string Message)> Put(Guid idCha, T objSource, Guid id);
        Task<(Guid? Result, int Code, string Message)> Delete(Guid idCha, Guid id);
    }
}