using System;


namespace Mediator_1
{
    public class ChatRoom
    {
        public static void ShowMessage(User user, string message)
        {
            Console.WriteLine($"{DateTime.Now} [{user.Name}] : {message}");
        }
    }

    public class User
    {
        public string Name { get; set; }
        public User(string name)
        {
            Name = name;
        }
        public void SendMessage(string message)
        {
            ChatRoom.ShowMessage(this, message);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            User userFirst = new User("Andrey");
            User userSecond = new User("Irina");

            userFirst.SendMessage("Hello World!");
            userSecond.SendMessage("Hello Averyone!");

            Console.ReadLine();
        }
    }
}