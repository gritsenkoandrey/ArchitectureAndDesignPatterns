using System;


namespace Proxy_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            IDisplayImage image = new ProxyImage(@"f:\Photo\Изображение 001.jpg");

            //Файл будет загружен с жесткого диска и затем отображен
            image.Display();
            Console.WriteLine("...");

            //Файл будет отображен без загрузки с диска
            image.Display();

            Console.ReadLine();
        }
    }
}