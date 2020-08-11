using System;


namespace Interface_Segregation_Principle_3
{
    class Camera : IPhoto
    {
        public void TakePhoto()
        {
            Console.WriteLine("Фотографируем");
        }
    }
}