using Store_Online.Core.Interfaces;
using Store_Online.Modules.Coffee.Models;

namespace Store_Online.Modules.Coffee.Services;

public class ProductService
{
    private readonly IApiService _api;

    public ProductService(IApiService api)
    {
        _api = api;
    }

    public async Task<List<ProductModel>> GetProductsAsync()
    {
        return await _api.GetAsync<List<ProductModel>>("products");
    }
}
