using System.Collections.Generic;
using System.Linq;

namespace ProjectT1.DictionaryAPI.Infrastructure.Services {
    public class MsCodeValidator {
        public static bool CheckValidMsCode(string msCode, IEnumerable<string> lstMsCode) {
            try {
                return !lstMsCode.Contains(msCode);
            }
            catch (Exception ex) {
                throw new Exception(ex.Message, ex);
            }

        }
    }
}