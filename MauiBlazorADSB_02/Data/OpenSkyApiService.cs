using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace MauiBlazorADSB_02.Data
{
    internal class OpenSkyApiService
    {
        private readonly HttpClient _httpClient;
        public OpenSkyApiService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(Constants.API_BASE_URL);
        }
        public async Task<Object> GetOpenSkyInformationAsync(string minlatitude, string minlongitude, string maxlatitude, string maxlongitude)
        {
            if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
            {
                return null;
            }
            //https_//opensky-network.org/api/states/all?lamin=37.020&lomin=-109.080&lamax=40.980&lomax=-102.080
            return await _httpClient.GetFromJsonAsync<Object>($"all?lamin={minlatitude}&lomin={minlongitude}&lamax={maxlatitude}&lomax={maxlongitude}");
        }

        public async Task<OpenSkyApiModel> GetOpenSkyInformationAsync2(string minlatitude, string minlongitude, string maxlatitude, string maxlongitude)
        {
            if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
            {
                return null;
            }
            //https_//opensky-network.org/api/states/all?lamin=37.020&lomin=-109.080&lamax=40.980&lomax=-102.080
            return await _httpClient.GetFromJsonAsync<OpenSkyApiModel>($"all?lamin={minlatitude}&lomin={minlongitude}&lamax={maxlatitude}&lomax={maxlongitude}");
        }
    }
}
