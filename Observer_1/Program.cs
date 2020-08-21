using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var om = new ObservableMinerals();
            var goldObserver = new GoldObserver();
            var silverObserver = new SilverObserver();
            var platinaObserver = new PlatinaObserver();
            IEnumerable<Mineral> minerals = new MineralRepository().GetMinerals();

            using (om.Subscribe(goldObserver))
            {
                using (om.Subscribe(silverObserver))
                {
                    using (om.Subscribe(platinaObserver))
                    {
                        foreach (var mineral in minerals)
                        {
                            om.Mineral = mineral;
                        }
                        om.Stop();
                    }
                }
            }

            Console.ReadLine();
        }
    }
}