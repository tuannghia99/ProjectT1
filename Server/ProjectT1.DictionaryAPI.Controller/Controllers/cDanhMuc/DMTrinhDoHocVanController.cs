using Microsoft.AspNetCore.Mvc;
using ProjectT1.DictionaryAPI.Infrastructure.DTOs;
using ProjectT1.DictionaryAPI.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectT1.DictionaryAPI.Controller {
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/danhMuc/TrinhDoHocVan")]
    public class DMTrinhDoHocVanController(ITrinhDoHocVanService service) : ControllerBase() {
        [HttpGet]
        public async Task<ActionResult<OperationResultInfo<IEnumerable<TrinhDoHocVanDTO>>>> GetAll() {
            var (Result, Code, Message) = await service.GetAll();
            return StatusCode(Code, clsCommon.ApiResponse(Result, Code, Message));
        }

        [HttpGet]
        [Route("{Id}")]
        public async Task<ActionResult<OperationResultInfo<TrinhDoHocVanDTO>>> GetById(Guid Id) {
            var (Result, Code, Message) = await service.GetById(Id);
            return StatusCode(Code, clsCommon.ApiResponse(Result, Code, Message));
        }

        [HttpPost]
        public async Task<ActionResult<OperationResultInfo<IEnumerable<TrinhDoHocVanDTO>>>> Post(IEnumerable<TrinhDoHocVanDTO> dataSource) {
            var (Result, Code, Message) = await service.Post(dataSource);
            return StatusCode(Code, clsCommon.ApiResponse(Result, Code, Message));
        }

        [HttpPut]
        [Route("{Id}")]
        public async Task<ActionResult<OperationResultInfo<TrinhDoHocVanDTO>>> Put(TrinhDoHocVanDTO objSource, Guid Id) {
            var (Result, Code, Message) = await service.Put(objSource, Id);
            return StatusCode(Code, clsCommon.ApiResponse(Result, Code, Message));
        }

        [HttpDelete]
        [Route("{Id}")]
        public async Task<ActionResult<OperationResultInfo<Guid>>> Delete(Guid Id) {
            var (Result, Code, Message) = await service.Delete(Id);
            return StatusCode(Code, clsCommon.ApiResponse(Result, Code, Message));
        }
    }
}