using ProjectT1.Client.ServerBusiness.Infrastructure.Contracts;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectT1.Client.ServerBusiness.Infrastructure {
    public class ProjectT1ApiClientBase : IProjectT1ApiClientBase {
        public static int Counter = 0; // Bộ đếm số lần truy xuất dữ liệu
        public string BaseUrl { get; set; }

        string _serviceToken;
        public void SetBearerToken(string SToken) => _serviceToken = SToken;

        protected Task PrepareRequestAsync(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, string url) {
            Interlocked.Increment(ref Counter);
            if (_serviceToken != null) request.Headers.Authorization = new("Bearer", _serviceToken);
            return Task.CompletedTask;
        }
        protected Task PrepareRequestAsync(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, System.Text.StringBuilder urlBuilder) {
            return Task.CompletedTask;
        }
        protected Task ProcessResponseAsync(System.Net.Http.HttpClient client, System.Net.Http.HttpResponseMessage response, CancellationToken token) {
            return Task.CompletedTask;
        }

        public void SetServiceToken(string SToken) => SetBearerToken(SToken);
    }
}