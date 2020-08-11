using System;


namespace Interface_Segregation_Principle_3
{
    class Phone : /*IPhone,*/ ICall, IPhoto, IVideo, IWeb
    {
        public void Call()
        {
            Console.WriteLine("Звоним");
        }
        public void TakePhoto()
        {
            Console.WriteLine("Фотографируем");
        }
        public void MakeVideo()
        {
            Console.WriteLine("Снимаем видео");
        }
        public void BrowseInternet()
        {
            Console.WriteLine("Серфим в интернете");
        }
    }
}