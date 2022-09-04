using Dapr.Client;
using Microsoft.AspNetCore.Mvc;

namespace dapr.webapi.orders.Controllers;

[ApiController]
public sealed class OrderController : ControllerBase
{
    [HttpPost("submit")]
    public async Task<ActionResult<Guid>> SubmitOrder([FromBody] Order order, [FromServices] DaprClient daprClient)
    {
        order.Id = Guid.NewGuid();
        if (order.Items.Count == 0)
        {
            order.Items.Add(new OrderLine("Product-1", 5));
        }

        foreach (var item in order.Items)
        {
            var data = new
            {
                sku = item.ProductCode,
                quantity = item.Quantity
            };

            try
            {
                var result = await daprClient.InvokeMethodAsync<object, dynamic>(HttpMethod.Post, "dapr-webapi-reservation", "reserve", data);
            }
            catch (Exception ex)
            {

            }
        }

        return order.Id;
    }
}
