namespace ProjectT1.CoreClient {
    public class Account {
        public Guid Oid { get; set; }
        public string AccCode { get; set; }
        public string AccName { get; set; }
        public string Url { get; set; }
        public string Username { get; set; }

        public Account(string accCode, string accName, string url, string username) {
            Oid = Guid.NewGuid();
            AccCode = accCode;
            AccName = accName;
            Url = url;
            Username = username;
        }

        public static IEnumerable<Account> GetListAccounts() {
            var data = new List<Account>() {
                new Account("1001", "Bộ Tài chính", @"vapps:\\vpm2022.vcsvietnam.com\ver1\test\botc", "admin@botaichinh.y1test"),
            };
            return data;
        }
    }
}
