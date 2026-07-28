using Newtonsoft.Json;
using Store_Online.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Store_Online.Core.Services
{
    public class ApiService : IApiService
    {
        private readonly HttpClient _client;
        private readonly ConfigurationService _configuration;

        private static readonly JsonSerializerSettings JsonSettings = new()
        {
            NullValueHandling = NullValueHandling.Ignore
        };

        public string? Token { get; set; }

        public ApiService(ConfigurationService configuration)
        {
            _configuration = configuration;

            _client = new HttpClient
            {
                BaseAddress = new Uri(_configuration.ApiUrl),
                Timeout = TimeSpan.FromSeconds(30)
            };

            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private void SetAuthorization()
        {
            string? token = string.IsNullOrWhiteSpace(Token)
                ? AppSession.Token
                : Token;

            _client.DefaultRequestHeaders.Authorization =
                string.IsNullOrWhiteSpace(token)
                    ? null
                    : new AuthenticationHeaderValue("Bearer", token);
        }

        private static StringContent CreateJsonContent(object data)
        {
            ArgumentNullException.ThrowIfNull(data);

            return new StringContent(
                JsonConvert.SerializeObject(data, JsonSettings),
                Encoding.UTF8,
                "application/json");
        }

        private static async Task<T> ReadResponseAsync<T>(HttpResponseMessage response)
        {
            string json = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                if (!string.IsNullOrWhiteSpace(json))
                {
                    try
                    {
                        ApiResponse<T>? apiResponse =
                            JsonConvert.DeserializeObject<ApiResponse<T>>(json);

                        if (apiResponse != null &&
                            !string.IsNullOrWhiteSpace(apiResponse.Message))
                        {
                            throw new HttpRequestException(apiResponse.Message);
                        }
                    }
                    catch (JsonException)
                    {
                    }
                }

                throw new HttpRequestException(
                    $"HTTP {(int)response.StatusCode} ({response.ReasonPhrase})");
            }

            if (string.IsNullOrWhiteSpace(json))
            {
                return default!;
            }

            return JsonConvert.DeserializeObject<T>(json)!;
        }

        public async Task<T> LoginAsync<T>(string email, string password)
        {
            var content = CreateJsonContent(new
            {
                email,
                password
            });

            using HttpResponseMessage response =
                await _client.PostAsync("auth/login", content);

            return await ReadResponseAsync<T>(response);
        }

        public async Task<T> GetAsync<T>(string endpoint)
        {
            if (string.IsNullOrWhiteSpace(endpoint))
                throw new ArgumentException("Endpoint cannot be empty.", nameof(endpoint));

            SetAuthorization();

            using HttpResponseMessage response =
                await _client.GetAsync(endpoint);

            return await ReadResponseAsync<T>(response);
        }

        public async Task<T> PostAsync<T>(string endpoint, object data)
        {
            if (string.IsNullOrWhiteSpace(endpoint))
                throw new ArgumentException("Endpoint cannot be empty.", nameof(endpoint));

            ArgumentNullException.ThrowIfNull(data);

            SetAuthorization();

            using HttpResponseMessage response =
                await _client.PostAsync(endpoint, CreateJsonContent(data));

            return await ReadResponseAsync<T>(response);
        }

        public async Task<T> PutAsync<T>(string endpoint, object data)
        {
            if (string.IsNullOrWhiteSpace(endpoint))
                throw new ArgumentException("Endpoint cannot be empty.", nameof(endpoint));

            ArgumentNullException.ThrowIfNull(data);

            SetAuthorization();

            using HttpResponseMessage response =
                await _client.PutAsync(endpoint, CreateJsonContent(data));

            return await ReadResponseAsync<T>(response);
        }

        public async Task<T> DeleteAsync<T>(string endpoint)
        {
            if (string.IsNullOrWhiteSpace(endpoint))
                throw new ArgumentException("Endpoint cannot be empty.", nameof(endpoint));

            SetAuthorization();

            using HttpResponseMessage response =
                await _client.DeleteAsync(endpoint);

            return await ReadResponseAsync<T>(response);
        }
    }
}