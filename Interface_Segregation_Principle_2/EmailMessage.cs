using System;


namespace Interface_Segregation_Principle_2
{
    class EmailMessage : IEmailMessage
    {
        public string Text { get; set; }
        public string Subject { get; set; }
        public string ToAddress { get; set; }
        public string FromAddress { get; set; }
        //public byte[] Voice { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Send()
        {
            Console.WriteLine("Отправляем по Email сообщение: {0}", Text);
        }
    }
}