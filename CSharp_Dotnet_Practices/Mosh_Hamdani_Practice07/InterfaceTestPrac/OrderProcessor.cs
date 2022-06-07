namespace InterfaceTestPrac
{
    public class OrderProcessor
    {
        private readonly IShippingCalculator _shippingCalculator;

        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            _shippingCalculator = new ShippingCalculator();
        }

        public void Process(Order order)
        {
            if(order.IsShipped)
            {
                throw new InvalidOperationException("This Order is already Processed.");
            }
            order.shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }
}
