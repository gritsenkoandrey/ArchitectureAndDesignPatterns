namespace Command_1
{
    public class BuyProduct : IOrder
    {
        private Product _product;

        public BuyProduct(Product product)
        {
            _product = product;
        }

        public void Execute()
        {
            _product.Buy();
        }
    }
}