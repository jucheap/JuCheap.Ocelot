using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace JuCheap.Product.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET api/product
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "product-1", "product-2" };
        }

        // GET api/product/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/product
        [HttpPost]
        public ActionResult<bool> Post([FromBody] string value)
        {
            return true;
        }

        // PUT api/product/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] string value)
        {
            return true;
        }

        // DELETE api/product/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return true;
        }
    }
}
