using Store_Online.Core.Services;
using Store_Online.Modules.Coffee.Models;

namespace Store_Online.Modules.Coffee.Services;

public class ProductService
{
    private readonly ApiService _api =
        new();

    public async Task<List<ProductModel>>
        GetProductsAsync()
    {
        return await _api.GetAsync<
            List<ProductModel>>
            ("products");
    }
}
