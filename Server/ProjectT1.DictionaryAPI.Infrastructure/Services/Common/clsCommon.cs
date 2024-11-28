using app.StdFramework;
using Microsoft.AspNetCore.Http;

namespace ProjectT1.DictionaryAPI.Infrastructure.Services {
    public static class clsCommon {
        #region Variables
        public const string g_DefaultUser = "admin";
        public static Guid g_DefaultIdDonVi = Guid.Empty;
        #endregion

        #region Template api response
        public static OperationResultInfo<T> ApiResponse<T>(T result, int code, string message = null) {
            OperationResultInfo<T> operationResult;
            switch (code) {
                case StatusCodes.Status200OK: operationResult = new OperationResultInfo<T>(true, "200", (message == null) ? "OK" : message, (message == null) ? "OK" : message); break;
                case StatusCodes.Status201Created: operationResult = new OperationResultInfo<T>(true, "201", (message == null) ? "Created" : message, (message == null) ? "Created" : message); break;
                case StatusCodes.Status404NotFound: operationResult = new OperationResultInfo<T>(false, "404", (message == null) ? "Not Found" : message, (message == null) ? "Not Found" : message); break;
                case StatusCodes.Status405MethodNotAllowed: operationResult = new OperationResultInfo<T>(false, "405", (message == null) ? "Method Not Allowed" : message, (message == null) ? "Method Not Allowed" : message); break;
                case StatusCodes.Status422UnprocessableEntity: operationResult = new OperationResultInfo<T>(false, "422", "Validate Fail", (message == null) ? "Unprocessable Entity" : message); break;
                default: operationResult = new OperationResultInfo<T>(false, "400", (message == null) ? "Bad Request" : message, (message == null) ? "Bad Request" : message); break;
            }

            operationResult.Result = result;
            operationResult.UserName = g_DefaultUser;
            operationResult.CreateDate = DateTime.Now;
            return operationResult;
        }
        #endregion
    }
}