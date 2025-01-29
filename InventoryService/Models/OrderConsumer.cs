using MassTransit;

namespace InventoryService.Models
{
    public class OrderConsumer : IConsumer<Order>
    {
        public async Task Consume(ConsumeContext<Order> context)
        {
            var msg = context.Message;

            await Console.Out.WriteLineAsync(msg.ToString());
        }
    }
}
