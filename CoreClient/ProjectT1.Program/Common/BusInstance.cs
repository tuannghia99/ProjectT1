using AutoMapper;
using Microsoft.Extensions.Logging;



#if JSONBUS
using ProjectT1.Client.JsonBusiness;
#elif SERVERBUS
using ProjectT1.Client.ServerBusiness;
#endif

namespace ProjectT1.CoreClient {
    public class BusInstance {
        private static readonly string _y4cBaseUrl = @"http://192.168.1.10:3037/";
        //private static readonly string _y4cBaseUrl = @"http://localhost:64950/";

        //private static IProjectT1Client _y4cClient;
        private static ILogger _logger;
        private static app.StdCommon.SimpleApiClient _y4cApiClient;

        public static void InitApiClient(string serviceToken, string baseServiceUri, ILogger ilogger) {
            _y4cApiClient = new app.StdCommon.SimpleApiClient(_y4cBaseUrl) { ServiceToken = serviceToken };

            //_y4cClient = new ProjectT1Client(_y4cApiClient.HttpClient) { BaseUrl = _y4cBaseUrl };
            _logger = ilogger;
        }

        private static IMapper CreateMapper() {
            var mappingConfig = new MapperConfiguration(mc => {
                //mc.AddProfile(new DonViTinhPXIMappingProfile());
            });

            return mappingConfig.CreateMapper();
        }
        public static readonly string _strBusVersion = "Server Business";
    }
}
