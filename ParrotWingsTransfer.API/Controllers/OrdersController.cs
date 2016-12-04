using System.Web.Http;
using ParrotWingsTransfer.API.Models;

namespace ParrotWingsTransfer.API.Controllers
{
    [RoutePrefix("api/Orders")]
    public class OrdersController : ApiController
    {
        [Authorize]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(Order.CreateOrders());
        }

    }
}