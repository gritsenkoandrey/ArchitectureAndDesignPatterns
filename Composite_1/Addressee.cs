using System;


namespace Composite_1
{
    public class Addressee : IParticipant
    {
        public string Name { get; set; }

        public void Send()
        {
            Console.WriteLine($"Письмо {Name} отправлено.");
        }
    }
}