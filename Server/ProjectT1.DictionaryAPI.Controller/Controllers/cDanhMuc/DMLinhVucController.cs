using Microsoft.AspNetCore.Mvc;
using ProjectT1.DictionaryAPI.Infrastructure.DTOs;
using ProjectT1.DictionaryAPI.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectT1.DictionaryAPI.Controller {
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/danhMucT1/LinhVuc")]
    public class DMLinhVucController(ILinhVucService service) : VControllerBase(resourceName: "TEMP") {
        [HttpGet]
        public async Task<ActionResult<OperationResultInfo<IEnumerable<LinhVucDTO>>>> GetAll() {
            var (statusCode, ticket) = await VAuthorize(ePermission.ReadOnly);
            if (statusCode != Microsoft.AspNetCore.Http.StatusCodes.Status200OK) return new StatusCodeResult(statusCode);

            var (Result, Code, Message) = await service.GetAll(ticket);
            return StatusCode(Code, clsCommon.ApiResponse(Result, Code, Message));
        }

        [HttpGet]
        [Route("{Id}")]
        public async Task<ActionResult<OperationResultInfo<LinhVucDTO>>> GetById(Guid Id) {
            var (statusCode, ticket) = await VAuthorize(ePermission.ReadOnly);
            if (statusCode != Microsoft.AspNetCore.Http.StatusCodes.Status200OK) return new StatusCodeResult(statusCode);

            var (Result, Code, Message) = await service.GetById(ticket, Id);
            return StatusCode(Code, clsCommon.ApiResponse(Result, Code, Message));
        }

        [HttpPost]
        public async Task<ActionResult<OperationResultInfo<IEnumerable<LinhVucDTO>>>> Post(IEnumerable<LinhVucDTO> dataSource) {
            var (statusCode, ticket) = await VAuthorize(ePermission.ReadOnly);
            if (statusCode != Microsoft.AspNetCore.Http.StatusCodes.Status200OK) return new StatusCodeResult(statusCode);

            var (Result, Code, Message) = await service.Post(ticket, dataSource);
            return StatusCode(Code, clsCommon.ApiResponse(Result, Code, Message));
        }

        [HttpPut]
        [Route("{Id}")]
        public async Task<ActionResult<OperationResultInfo<LinhVucDTO>>> Put(LinhVucDTO objSource, Guid Id) {
            var (statusCode, ticket) = await VAuthorize(ePermission.ReadOnly);
            if (statusCode != Microsoft.AspNetCore.Http.StatusCodes.Status200OK) return new StatusCodeResult(statusCode);

            var (Result, Code, Message) = await service.Put(ticket, objSource, Id);
            return StatusCode(Code, clsCommon.ApiResponse(Result, Code, Message));
        }

        [HttpDelete]
        [Route("{Id}")]
        public async Task<ActionResult<OperationResultInfo<Guid>>> Delete(Guid Id) {
            var (statusCode, ticket) = await VAuthorize(ePermission.ReadOnly);
            if (statusCode != Microsoft.AspNetCore.Http.StatusCodes.Status200OK) return new StatusCodeResult(statusCode);

            var (Result, Code, Message) = await service.Delete(ticket, Id);
            return StatusCode(Code, clsCommon.ApiResponse(Result, Code, Message));
        }
    }
}