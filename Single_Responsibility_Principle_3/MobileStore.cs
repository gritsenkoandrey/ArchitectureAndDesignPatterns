using System;
using System.Collections.Generic;


namespace Single_Responsibility_Principle_3
{
    class MobileStore
    {
        List<Phone> phones = new List<Phone>();
        public IPhoneReader Reader { get; set; }
        public IPhoneBinder Binder { get; set; }
        public IPhoneValidator Validator { get; set; }
        public IPhoneSaver Saver { get; set; }

        public MobileStore(IPhoneReader reader, IPhoneBinder binder,
            IPhoneValidator validator, IPhoneSaver saver)
        {
            Reader = reader;
            Binder = binder;
            Validator = validator;
            Saver = saver;
        }

        public void Process()
        {
            string[] data = Reader.GetInputData();
            Phone phone = Binder.CreatePhone(data);

            if (Validator.IsValid(phone))
            {
                phones.Add(phone);
                Saver.Save(phone, "store.txt");
                Console.WriteLine("Данные успешно обработаны");
            }
            else
            {
                Console.WriteLine("Некорректные данные");
            }
        }

        //public void Process()
        //{
        //    Console.WriteLine("Введите модель:");
        //    string model = Console.ReadLine();
        //    Console.WriteLine("Введите цену:");
        //    int price = 0;
        //    bool result = int.TryParse(Console.ReadLine(), out price);

        //    if (result == false || price <= 0 || string.IsNullOrEmpty(model))
        //    {
        //        throw new Exception("Некорректно введены данные");
        //    }
        //    else
        //    {
        //        phones.Add(new Phone { Model = model, Price = price });
        //        // сохраняем данные в файл
        //        using (StreamWriter writer = new StreamWriter("store.txt", true))
        //        {
        //            writer.WriteLine(model);
        //            writer.WriteLine(price);
        //        }
        //        Console.WriteLine("Данные успешно обработаны");
        //    }
        //}
    }
}