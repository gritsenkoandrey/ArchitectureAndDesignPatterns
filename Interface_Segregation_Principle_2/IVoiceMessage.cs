namespace Interface_Segregation_Principle_2
{
    interface IVoiceMessage : IMessage
    {
        byte[] Voice { get; set; }
    }
}