using app.StdCommon;
using AutoMapper;
using CASAuthServiceClient;
using GenerateModelSQLServerEFCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProjectT1.DictionaryAPI.Infrastructure.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectT1.DictionaryAPI.Infrastructure.Services {
    public class LinhVucService(
        DatabaseContext _context,
        IMapper _mapper,
        ILogger<LinhVucService> _logger,
        IValidator<LinhVucDTO> _validator
        ) : ILinhVucService {
        const string _category = "LinhVuc";

        public async Task<(IEnumerable<LinhVucDTO> Result, int Code, string Message)> GetAll(WebServiceTicket ticket) {
            _logger.LogInformation("GetAll called");
            try {
                var data = await _context.Dm0002s.AsNoTracking().Where(x => x.CategoryId == _category && x.LinkGuid20 == ticket.ServiceWebCustomerID && x.Boolean10 == true).ToListAsync();
                var res = data.Select(_mapper.Map<Dm0002, LinhVucDTO>).ToList();

                _logger.LogTrace("GetAll success: Result count {ResultCount}", res.Count);
                return (res, StatusCodes.Status200OK, null);
            }
            catch (Exception ex) {
                _logger.LogError(ex, nameof(GetAll));
                return (null, StatusCodes.Status400BadRequest, ex.Message);
            }
        }

        public async Task<(LinhVucDTO Result, int Code, string Message)> GetById(WebServiceTicket ticket, Guid id) {
            _logger.LogInformation("GetById called: Id {Id}", id);
            try {
                var obj = await _context.Dm0002s.AsNoTracking().FirstOrDefaultAsync(x => x.CategoryId == _category && x.LinkGuid20 == ticket.ServiceWebCustomerID && x.Boolean10 == true && x.Oid == id);
                if (obj == null)
                    return (null, StatusCodes.Status404NotFound, null);

                var res = _mapper.Map<Dm0002, LinhVucDTO>(obj);

                _logger.LogTrace("GetById success: Id {Id}", id);
                return (res, StatusCodes.Status200OK, null);
            }
            catch (Exception ex) {
                _logger.LogError(ex, nameof(GetById));
                return (null, StatusCodes.Status400BadRequest, ex.Message);
            }
        }

        public async Task<(IEnumerable<LinhVucDTO> Result, int Code, string Message)> Post(WebServiceTicket ticket, IEnumerable<LinhVucDTO> dataSource) {
            _logger.LogInformation("Post called: DataSource {DataSource}", dataSource.JsonSerialize());
            using var transaction = await _context.Database.BeginTransactionAsync();
            try {
                var lstMsCode = await _context.Dm0002s.AsNoTracking().Where(x => x.CategoryId == _category && x.Boolean10 == true).Select(x => x.Mscode).ToListAsync();
                foreach (var item in dataSource) {
                    if (!MsCodeValidator.CheckValidMsCode(item.MaSo, lstMsCode)) {
                        var mess = $"MsCode \'{item.MaSo}\' is duplicate";
                        _logger.LogTrace("Post processing CheckMsCode: {Mess}", mess);
                        return (null, StatusCodes.Status400BadRequest, mess);
                    }
                }

                var dataDest = dataSource.Select(_mapper.Map<LinhVucDTO, Dm0002>).ToList();
                dataDest.ForEach(x => {
                    x.LinkGuid20 = ticket.ServiceWebCustomerID;
                    x.Boolean10 = true;
                    x.Mscode = (x.Mscode.IsNullOrEmpty()) ? string.Empty : x.Mscode;
                    x.Msname = (x.Msname.IsNullOrEmpty()) ? string.Empty : x.Msname;
                    x.CategoryId = _category;
                    x.Sorting = 1;
                    x.IsUsing = true;
                    x.IsModifiable = true;
                    x.LastAction = (int)g_LastAction.New;
                    x.LastModified = DateTime.Now;
                });

                await _context.Dm0002s.AddRangeAsync(dataDest);
                await _context.SaveChangesAsync();
                await transaction.CommitAsync();

                _logger.LogTrace("Post success: DataSource {DataSource}, Result count {ResultCount}", dataSource.JsonSerialize(), dataSource.Count());
                return (dataSource, StatusCodes.Status201Created, null);
            }
            catch (Exception ex) {
                await transaction.RollbackAsync();
                _logger.LogError(ex, nameof(Post));
                return (null, StatusCodes.Status400BadRequest, ex.Message);
            }
        }

        public async Task<(LinhVucDTO Result, int Code, string Message)> Put(WebServiceTicket ticket, LinhVucDTO objSource, Guid id) {
            _logger.LogInformation("Put called: ObjSource {ObjSource}, Id {id}", objSource.JsonSerialize(), id);
            using var transaction = await _context.Database.BeginTransactionAsync();
            try {
                var objDest = await _context.Dm0002s.FirstOrDefaultAsync(x => x.CategoryId == _category && x.Boolean10 == true && x.Oid == id);
                if (objDest == null)
                    return (null, StatusCodes.Status404NotFound, null);

                var lstMsCode = await _context.Dm0002s.AsNoTracking().Where(x => x.CategoryId == _category && x.Boolean10 == true).Select(x => x.Mscode).ToListAsync();
                if (objSource.MaSo != objDest.Mscode) {
                    if (!MsCodeValidator.CheckValidMsCode(objSource.MaSo, lstMsCode)) {
                        var mess = $"MsCode \'{objSource.MaSo}\' is duplicate";
                        _logger.LogTrace("Put processing CheckMsCode: {Mess}", mess);
                        return (null, StatusCodes.Status400BadRequest, mess);
                    }
                }

                _mapper.Map(objSource, objDest);
                objDest.LinkGuid20 = ticket.ServiceWebCustomerID;
                objDest.Boolean10 = true;
                objDest.Mscode = (objDest.Mscode.IsNullOrEmpty()) ? string.Empty : objDest.Mscode;
                objDest.Msname = (objDest.Msname.IsNullOrEmpty()) ? string.Empty : objDest.Msname;
                objDest.CategoryId = _category;
                objDest.Sorting = 1;
                objDest.IsUsing = true;
                objDest.IsModifiable = true;
                objDest.LastAction = (int)g_LastAction.Update;
                objDest.LastModified = DateTime.Now;

                await _context.SaveChangesAsync();
                await transaction.CommitAsync();

                _logger.LogTrace("Put success: ObjSource {ObjSource}, Id {Id}", objSource.JsonSerialize(), id);
                return (objSource, StatusCodes.Status200OK, null);
            }
            catch (Exception ex) {
                await transaction.RollbackAsync();
                _logger.LogError(ex, nameof(Put));
                return (null, StatusCodes.Status400BadRequest, ex.Message);
            }
        }

        public async Task<(Guid? Result, int Code, string Message)> Delete(WebServiceTicket ticket, Guid id) {
            _logger.LogInformation("Delete called: Id {Id}", id);
            using var transaction = await _context.Database.BeginTransactionAsync();
            try {
                var objDest = await _context.Dm0002s.FirstOrDefaultAsync(x => x.CategoryId == _category && x.LinkGuid20 == ticket.ServiceWebCustomerID && x.Boolean10 == true && x.Oid == id);
                if (objDest == null)
                    return (null, StatusCodes.Status404NotFound, null);

                _context.Dm0002s.Remove(objDest);
                await _context.SaveChangesAsync();
                await transaction.CommitAsync();

                _logger.LogTrace("Delete success: Id {Id}", id);
                return (id, StatusCodes.Status200OK, null);
            }
            catch (Exception ex) {
                await transaction.RollbackAsync();
                _logger.LogError(ex, nameof(Delete));
                return (null, StatusCodes.Status400BadRequest, ex.Message);
            }
        }
    }
}