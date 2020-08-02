namespace Interface_Segregation_Principle_2
{
    interface IMessage
    {
        void Send();
        //string Text { get; set; }
        //string Subject { get; set; }
        string ToAddress { get; set; }
        string FromAddress { get; set; }
        //byte[] Voice { get; set; }
    }
}