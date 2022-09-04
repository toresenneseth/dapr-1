namespace dapr.webapi.orders.Controllers
{
    public record OrderLine(string ProductCode, int Quantity);

    public class Order
    {
        public Guid? Id { get; set; }

        public List<OrderLine> Items { get; set; } = new List<OrderLine>();
    }
}
