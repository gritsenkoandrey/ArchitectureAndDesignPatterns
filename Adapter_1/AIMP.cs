using System;


namespace Adapter_1
{
    public class AIMP : IModernMediaPlayer
    {
        public void PlayFlac(string fileName)
        {
            Console.WriteLine($"Воспроизводим flac-файл. Имя файла: {fileName}");
        }

        public void PlayMkv(string fileName)
        {
            Console.WriteLine($"Воспроизводим mkv-файл. Имя файла {fileName}");
        }
    }
}