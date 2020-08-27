using System.Collections.Generic;


namespace Observer_1
{
    public class MineralRepository
    {
        /// <summary>
        /// Хранение котировок ценных металлов
        /// </summary>
        public IEnumerable<Mineral> GetMinerals()
        {
            return new List<Mineral>()
            {
                new Mineral{Name = "Золото", Price = 1200},
                new Mineral{Name = "Золото", Price = 1250},
                new Mineral{Name = "Золото", Price = 1225},
                new Mineral{Name = "Серебро", Price = 20},
                new Mineral{Name = "Серебро", Price = 25},
                new Mineral{Name = "Серебро", Price = 15},
                new Mineral{Name = "Платина", Price = 2000},
                new Mineral{Name = "Платина", Price = 1800},
                new Mineral{Name = "Платина", Price = 1900}
            };
        }
    }
}