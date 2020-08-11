using System;


namespace Interface_Segregation_Principle_2
{
    class SmsMessage : ITextMessage
    {
        public string Text { get; set; }
        //public string Subject
        //{ 
        //    get => throw new NotImplementedException();
        //    set => throw new NotImplementedException();
        //}
        public string ToAddress { get; set; }
        public string FromAddress { get; set; }
        //public byte[] Voice { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Send()
        {
            Console.WriteLine("Отправляем по Sms сообщение: {0}", Text);
        }
    }
}