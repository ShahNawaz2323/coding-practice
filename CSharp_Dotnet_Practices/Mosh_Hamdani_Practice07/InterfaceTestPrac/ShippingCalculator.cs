namespace InterfaceTestPrac
{
    public interface IShippingCalculator
    {
        float CalculateShipping(OrderProcessor order);
    }
    public class ShippingCalculator : IShippingCalculator
    {
        public float ShippingCalculator(Order order)
        {
            if(order.TotalPrice < 30f)
                return order.TotalPrice * 0.1f;
            
            return 0;
        }
    }
}
