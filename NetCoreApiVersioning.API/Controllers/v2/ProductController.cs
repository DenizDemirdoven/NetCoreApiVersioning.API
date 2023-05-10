using NetCoreApiVersioning.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace NetCoreApiVersioning.API.Controllers.v2
{

    
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("2.0")]
    public class ProductController : ControllerBase
    {
        [HttpGet("GetProducts")]
        public IActionResult GetProducts()
        {
            var list = ProductDataService.GetProductsv2();

            return Ok(list);
        }
    }
}

