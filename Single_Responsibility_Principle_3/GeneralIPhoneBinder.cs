using System;


namespace Single_Responsibility_Principle_3
{
    class GeneralIPhoneBinder : IPhoneBinder
    {
        private byte _minCountSymbol = 2;

        public Phone CreatePhone(string[] data)
        {
            if (data.Length >= _minCountSymbol)
            {
                int price = 0;

                if (int.TryParse(data[1], out price))
                {
                    return new Phone { Model = data[0], Price = price };
                }
                else
                {
                    throw new Exception("Ошибка привязчика модели Phone." +
                        "Некорректные данные для свойства Price");
                }
            }
            else
            {
                throw new Exception("Ошибка привязчика модели Phone." +
                    "Недостаточно данных для создания модели");
            }
        }
    }
}