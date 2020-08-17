using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var orange = new Product("Orange", 100);

            var buyProductOrder = new BuyProduct(orange);
            var selProductOrder = new SellProduct(orange);

            var provider = new Provider();
            provider.TakeOrder(buyProductOrder);
            provider.TakeOrder(buyProductOrder);
            provider.TakeOrder(buyProductOrder);
            provider.TakeOrder(selProductOrder);

            provider.MakeOrders();

            Console.ReadLine();
        }
    }
}