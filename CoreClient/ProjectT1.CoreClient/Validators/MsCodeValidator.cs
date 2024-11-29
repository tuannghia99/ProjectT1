using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectT1.CoreClient {
    public class MsCodeValidator {
        public static bool CheckValidMsCode(IEnumerable<string> lstMsCode, string msCode, bool isAddNew = true, string oldMsCode = null) {
            try {
                if (isAddNew) {
                    if (lstMsCode.Contains(msCode))
                        return false;
                }
                else {
                    if (msCode != oldMsCode)
                        if (lstMsCode.Contains(msCode))
                            return false;
                }
                return true;
            }
            catch (Exception ex) {
                throw new Exception(ex.Message, ex);
            }
        }
        public static bool CheckUniqueGuidId(IEnumerable<Guid?> lstGuidId, Guid? guidId, bool isAddNew = true, Guid? oldGuidId = null) {
            try {
                if (isAddNew) {
                    if (lstGuidId.Contains(guidId))
                        return false;
                }
                else {
                    if (guidId != oldGuidId)
                        if (lstGuidId.Contains(guidId))
                            return false;
                }
                return true;
            }
            catch (Exception ex) {
                throw new Exception(ex.Message, ex);
            }
        }
        public static bool CheckValidMsCode(IEnumerable<string> lstMsCode) {
            try {
                var uniqueItems = new HashSet<string>();
                foreach (var item in lstMsCode) {
                    if (!uniqueItems.Add(item))
                        return false;
                }
                return true;
            }
            catch (Exception ex) {
                throw new Exception(ex.Message, ex);
            }
        }
        public static bool CheckUniqueGuidId(IEnumerable<Guid?> lstGuidId) {
            try {
                var uniqueItems = new HashSet<Guid?>();
                foreach (var item in lstGuidId) {
                    if (!uniqueItems.Add(item))
                        return false;
                }
                return true;
            }
            catch (Exception ex) {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}