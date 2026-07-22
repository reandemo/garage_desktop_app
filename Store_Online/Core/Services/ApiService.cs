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

        public string? Token { get; set; }

        public ApiService()
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri("https://reanprogramming.com/api/v1/"),
                Timeout = TimeSpan.FromSeconds(30)
            };

            _client.DefaultRequestHeaders.Accept.Clear();

            _client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private void SetAuthorization()
        {
            var token = string.IsNullOrWhiteSpace(Token)
                ? AppSession.Token
                : Token;

            if (string.IsNullOrWhiteSpace(token))
            {
                _client.DefaultRequestHeaders.Authorization = null;
            }
            else
            {
                _client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", token);
            }
        }

        private static StringContent CreateJsonContent(object data)
        {
            return new StringContent(
                JsonConvert.SerializeObject(data),
                Encoding.UTF8,
                "application/json");
        }

        private async Task<T> ReadResponseAsync<T>(HttpResponseMessage response)
        {
            var json = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException(
                    $"HTTP {(int)response.StatusCode} ({response.ReasonPhrase}) : {json}");
            }

            if (string.IsNullOrWhiteSpace(json))
            {
                return default!;
            }

            return JsonConvert.DeserializeObject<T>(json)!;
        }

        public async Task<T> LoginAsync<T>(
            string email,
            string password)
        {
            var data = new
            {
                email,
                password
            };

            var content = CreateJsonContent(data);

            var response = await _client.PostAsync(
                "auth/login",
                content);

            return await ReadResponseAsync<T>(response);
        }

        public async Task<T> GetAsync<T>(string endpoint)
        {
            if (string.IsNullOrWhiteSpace(endpoint))
            {
                throw new ArgumentException(
                    "Endpoint cannot be empty.",
                    nameof(endpoint));
            }

            SetAuthorization();

            var response = await _client.GetAsync(endpoint);

            return await ReadResponseAsync<T>(response);
        }

        public async Task<T> PostAsync<T>(
            string endpoint,
            object data)
        {
            if (string.IsNullOrWhiteSpace(endpoint))
            {
                throw new ArgumentException(
                    "Endpoint cannot be empty.",
                    nameof(endpoint));
            }

            SetAuthorization();

            var content = CreateJsonContent(data);

            var response = await _client.PostAsync(
                endpoint,
                content);

            return await ReadResponseAsync<T>(response);
        }

        public async Task<T> PutAsync<T>(
            string endpoint,
            object data)
        {
            if (string.IsNullOrWhiteSpace(endpoint))
            {
                throw new ArgumentException(
                    "Endpoint cannot be empty.",
                    nameof(endpoint));
            }

            SetAuthorization();

            var content = CreateJsonContent(data);

            var response = await _client.PutAsync(
                endpoint,
                content);

            return await ReadResponseAsync<T>(response);
        }

        public async Task<T> DeleteAsync<T>(string endpoint)
        {
            if (string.IsNullOrWhiteSpace(endpoint))
            {
                throw new ArgumentException(
                    "Endpoint cannot be empty.",
                    nameof(endpoint));
            }

            SetAuthorization();

            var response = await _client.DeleteAsync(endpoint);

            return await ReadResponseAsync<T>(response);
        }
    }
}