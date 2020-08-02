namespace Interface_Segregation_Principle_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Photograph photograph = new Photograph();
            Phone phone = new Phone();
            photograph.TakePhoto(phone);
        }
    }
}