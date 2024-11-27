using CASAuthServiceClient;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectT1.DictionaryAPI.Infrastructure.Services {
    public interface ICRUDCategoryService<T> {
        Task<(IEnumerable<T> Result, int Code, string Message)> GetAll(WebServiceTicket ticket);
        Task<(T Result, int Code, string Message)> GetById(WebServiceTicket ticket, Guid id);
        Task<(IEnumerable<T> Result, int Code, string Message)> Post(WebServiceTicket ticket, IEnumerable<T> dataSource);
        Task<(T Result, int Code, string Message)> Put(WebServiceTicket ticket, T objSource, Guid id);
        Task<(Guid? Result, int Code, string Message)> Delete(WebServiceTicket ticket, Guid id);
    }

    public interface ICRUDFunctionService<T> {
        Task<(IEnumerable<T> Result, int Code, string Message)> GetAll(WebServiceTicket ticket);
        Task<(T Result, int Code, string Message)> GetById(WebServiceTicket ticket, Guid id);
        Task<(IEnumerable<T> Result, int Code, string Message)> Post(WebServiceTicket ticket, IEnumerable<T> dataSource);
        Task<(T Result, int Code, string Message)> Put(WebServiceTicket ticket, T objSource, Guid id);
        Task<(Guid? Result, int Code, string Message)> Delete(WebServiceTicket ticket, Guid id);
    }
}