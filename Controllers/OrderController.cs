using CQRSWithMediator.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CQRSWithMediator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : Controller
    {
        [HttpPost]
        [Route("addOrder")]
        public IActionResult AddOrder()
        {
            Order order = new()
            {
                CustomerId = 1,
                Items = "Jacket",
                quantity = 2
            };
            return Ok(order);
        }
    }
}
