namespace Command_1
{
    public class SellProduct : IOrder
    {
        private Product _product;

        public SellProduct(Product product)
        {
            _product = product;
        }

        public void Execute()
        {
            _product.Sell();
        }
    }
}