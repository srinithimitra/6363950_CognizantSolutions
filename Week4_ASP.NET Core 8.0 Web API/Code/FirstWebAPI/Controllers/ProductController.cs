using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FirstWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private static List<string> products = new List<string> { "Laptop", "Mobile" };

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(products);
        }

        [HttpPost]
        public ActionResult Post([FromBody] string product)
        {
            products.Add(product);
            return Ok(new { message = "Product added", product });
        }
    }
}
