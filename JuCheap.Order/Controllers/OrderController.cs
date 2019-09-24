using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace JuCheap.Order.Controllers
{
    /// <summary>
    /// 订单api
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        // GET api/order
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "order-1", "order-2" };
        }

        // GET api/order/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "order";
        }

        // POST api/order
        [HttpPost]
        public ActionResult<bool> Post([FromBody] string value)
        {
            return true;
        }

        // PUT api/order/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] string value)
        {
            return true;
        }

        // DELETE api/order/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return true;
        }
    }
}
