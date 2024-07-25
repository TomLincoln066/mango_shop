using Mango.Web.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Mango.Web.Models;
using Newtonsoft.Json;

namespace Mango.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<IActionResult> ProductIndex()
        {
            List<ProductDto> list = new List<ProductDto>();
            var response = await _productService.GetAllProductsAsync<ResponseDto>();
            list = JsonConvert.DeserializeObject<List<ProductDto>>(Convert.ToString(response.Result));
            return View(list);
        }

        public async Task<IActionResult> ProductCreate()
        {
            return View();
        }
    }
}
