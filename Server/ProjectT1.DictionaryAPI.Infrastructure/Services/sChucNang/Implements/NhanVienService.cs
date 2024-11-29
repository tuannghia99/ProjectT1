﻿using AutoMapper;
using GenerateModelSQLServerEFCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using ProjectT1.DictionaryAPI.Infrastructure.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectT1.DictionaryAPI.Infrastructure.Services {
    public class NhanVienService(
        DatabaseContext _context,
        IMapper _mapper,
        ILogger<NhanVienService> _logger,
        IValidator<NhanVienDTO> _validator
        ) : INhanVienService {

        public async Task<(IEnumerable<NhanVienDTO> Result, int Code, string Message)> GetAll() {
            _logger.LogInformation("GetAll called");
            try {
                var data = await _context.NhanViens.AsNoTracking().ToListAsync();
                var res = data.Select(_mapper.Map<NhanVien, NhanVienDTO>).ToList();

                _logger.LogTrace("GetAll success: Result count {ResultCount}", res.Count);
                return (res, StatusCodes.Status200OK, null);
            }
            catch (Exception ex) {
                _logger.LogError(ex, nameof(GetAll));
                return (null, StatusCodes.Status400BadRequest, ex.Message);
            }
        }

        public async Task<(NhanVienDTO Result, int Code, string Message)> GetById(Guid id) {
            _logger.LogInformation("GetById called: Id {Id}", id);
            try {
                var obj = await _context.NhanViens.AsNoTracking().FirstOrDefaultAsync(x => x.Oid == id);
                if (obj == null)
                    return (null, StatusCodes.Status404NotFound, null);

                var res = _mapper.Map<NhanVien, NhanVienDTO>(obj);

                _logger.LogTrace("GetById success: Id {Id}", id);
                return (res, StatusCodes.Status200OK, null);
            }
            catch (Exception ex) {
                _logger.LogError(ex, nameof(GetById));
                return (null, StatusCodes.Status400BadRequest, ex.Message);
            }
        }

        public async Task<(IEnumerable<NhanVienDTO> Result, int Code, string Message)> Post(IEnumerable<NhanVienDTO> dataSource) {
            _logger.LogInformation("Post called: DataSource {DataSource}", JsonConvert.SerializeObject(dataSource));
            using var transaction = await _context.Database.BeginTransactionAsync();
            try {
                var lstMsCode = await _context.NhanViens.AsNoTracking().Select(x => x.MaSo).ToListAsync();
                foreach (var item in dataSource) {
                    if (!MsCodeValidator.CheckValidMsCode(item.MaSo, lstMsCode)) {
                        var mess = $"MsCode \'{item.MaSo}\' is duplicate";
                        _logger.LogTrace("Post processing CheckMsCode: {Mess}", mess);
                        return (null, StatusCodes.Status400BadRequest, mess);
                    }
                }

                var dataDest = dataSource.Select(_mapper.Map<NhanVienDTO, NhanVien>).ToList();

                await _context.NhanViens.AddRangeAsync(dataDest);
                await _context.SaveChangesAsync();
                await transaction.CommitAsync();

                _logger.LogTrace("Post success: DataSource {DataSource}, Result count {ResultCount}", JsonConvert.SerializeObject(dataSource), dataSource.Count());
                return (dataSource, StatusCodes.Status201Created, null);
            }
            catch (Exception ex) {
                await transaction.RollbackAsync();
                _logger.LogError(ex, nameof(Post));
                return (null, StatusCodes.Status400BadRequest, ex.Message);
            }
        }

        public async Task<(NhanVienDTO Result, int Code, string Message)> Put(NhanVienDTO objSource, Guid id) {
            _logger.LogInformation("Put called: ObjSource {ObjSource}, Id {id}", JsonConvert.SerializeObject(objSource), id);
            using var transaction = await _context.Database.BeginTransactionAsync();
            try {
                var objDest = await _context.NhanViens.FirstOrDefaultAsync(x => x.Oid == id);
                if (objDest == null)
                    return (null, StatusCodes.Status404NotFound, null);

                var lstMsCode = await _context.NhanViens.AsNoTracking().Select(x => x.MaSo).ToListAsync();
                if (objSource.MaSo != objDest.MaSo) {
                    if (!MsCodeValidator.CheckValidMsCode(objSource.MaSo, lstMsCode)) {
                        var mess = $"MsCode \'{objSource.MaSo}\' is duplicate";
                        _logger.LogTrace("Put processing CheckMsCode: {Mess}", mess);
                        return (null, StatusCodes.Status400BadRequest, mess);
                    }
                }

                _mapper.Map(objSource, objDest);

                await _context.SaveChangesAsync();
                await transaction.CommitAsync();

                _logger.LogTrace("Put success: ObjSource {ObjSource}, Id {Id}", JsonConvert.SerializeObject(objSource), id);
                return (objSource, StatusCodes.Status200OK, null);
            }
            catch (Exception ex) {
                await transaction.RollbackAsync();
                _logger.LogError(ex, nameof(Put));
                return (null, StatusCodes.Status400BadRequest, ex.Message);
            }
        }

        public async Task<(Guid? Result, int Code, string Message)> Delete(Guid id) {
            _logger.LogInformation("Delete called: Id {Id}", id);
            using var transaction = await _context.Database.BeginTransactionAsync();
            try {
                var objDest = await _context.NhanViens.FirstOrDefaultAsync(x => x.Oid == id);
                if (objDest == null)
                    return (null, StatusCodes.Status404NotFound, null);

                _context.NhanViens.Remove(objDest);
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