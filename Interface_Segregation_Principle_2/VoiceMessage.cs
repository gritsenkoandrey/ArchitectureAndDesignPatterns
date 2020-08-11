using System;


namespace Interface_Segregation_Principle_2
{
    class VoiceMessage : IVoiceMessage
    {
        //public string Text { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public string Subject { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ToAddress { get; set; }
        public string FromAddress { get; set; }
        public byte[] Voice { get; set; }

        public void Send()
        {
            Console.WriteLine("Передача голосовой почты");
        }
    }
}