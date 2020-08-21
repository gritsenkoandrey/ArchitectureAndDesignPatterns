using System.Collections.Generic;


namespace Command_1
{
    public class Provider
    {
        private List<IOrder> _orderList = new List<IOrder>();

        public void TakeOrder(IOrder order)
        {
            _orderList.Add(order);
        }

        public void MakeOrders()
        {
            foreach (var order in _orderList)
            {
                order.Execute();
            }
            _orderList.Clear();
        }
    }
}