using System.IO;


namespace Single_Responsibility_Principle_3
{
    class GeneralPhoneSaver : IPhoneSaver
    {
        void IPhoneSaver.Save(Phone phone, string fileName)
        {
            using(StreamWriter writer = new StreamWriter(fileName, true))
            {
                writer.WriteLine(phone.Model);
                writer.WriteLine(phone.Price);
            }
        }
    }
}