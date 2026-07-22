namespace Store_Online.Core.Services
{
    public interface IApiService
    {
        /// <summary>
        /// JWT Access Token
        /// </summary>
        string? Token { get; set; }

        /// <summary>
        /// GET Request
        /// </summary>
        Task<T> GetAsync<T>(string endpoint);

        /// <summary>
        /// POST Request
        /// </summary>
        Task<T> PostAsync<T>(string endpoint, object data);

        /// <summary>
        /// PUT Request
        /// </summary>
        Task<T> PutAsync<T>(string endpoint, object data);

        /// <summary>
        /// DELETE Request
        /// </summary>
        Task<T> DeleteAsync<T>(string endpoint);
    }
}
