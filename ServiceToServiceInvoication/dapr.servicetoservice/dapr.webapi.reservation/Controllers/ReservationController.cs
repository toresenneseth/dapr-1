using Microsoft.AspNetCore.Mvc;

namespace dapr.webapi.reservation.Controllers
{
    [ApiController]
    public class ReservationController : ControllerBase
    {
        [HttpPost("reserve")]
        public async Task<IActionResult> Reserve([FromBody] (string sku, int quantity) reservation)
        {
            return Ok();
        }
    }
}
