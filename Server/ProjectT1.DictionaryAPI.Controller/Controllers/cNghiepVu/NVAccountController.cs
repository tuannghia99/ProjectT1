using Microsoft.AspNetCore.Mvc;
using ProjectT1.DictionaryAPI.Infrastructure.DTOs;
using ProjectT1.DictionaryAPI.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectT1.DictionaryAPI.Controller {
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/nghiepVu/Account")]
    public class NVAccountController(IAccountService service) : ControllerBase() {
        [HttpGet]
        [Route("HashPassword")]
        public async Task<ActionResult<OperationResultInfo<string>>> HashPassword(string password) {
            var (Result, Code, Message) = await service.HashPassword(password);
            return StatusCode(Code, clsCommon.ApiResponse(Result, Code, Message));
        }

        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult<OperationResultInfo<IEnumerable<bool>>>> Login(LoginRequestDTO request) {
            var (Result, Code, Message) = await service.Login(request);
            return StatusCode(Code, clsCommon.ApiResponse(Result, Code, Message));
        }

        [HttpPost]
        [Route("ChangePassword")]
        public async Task<ActionResult<OperationResultInfo<IEnumerable<bool>>>> ChangePassword(ChangePasswordRequestDTO request) {
            var (Result, Code, Message) = await service.ChangePassword(request);
            return StatusCode(Code, clsCommon.ApiResponse(Result, Code, Message));
        }

        [HttpPost]
        [Route("ResetPassword")]
        public async Task<ActionResult<OperationResultInfo<IEnumerable<bool>>>> ResetPassword(ResetPasswordRequestDTO request) {
            var (Result, Code, Message) = await service.ResetPassword(request);
            return StatusCode(Code, clsCommon.ApiResponse(Result, Code, Message));
        }
    }
}