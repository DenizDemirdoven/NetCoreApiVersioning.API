using Microsoft.AspNetCore.Mvc;
using NetCoreApiVersioning.API.Services;

namespace NetCoreApiVersioning.API.Controllers.v1
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class ProductController : ControllerBase
    {

        [HttpGet("GetProducts")]
        public IActionResult GetProducts()
        {
            var list = ProductDataService.GetProductsv1();

            return Ok(list);
        }
    }
}