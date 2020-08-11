namespace Interface_Segregation_Principle_2
{
    interface IEmailMessage : ITextMessage
    {
        string Subject { get; set; }
    }
}