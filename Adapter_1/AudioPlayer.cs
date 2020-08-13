using System;


namespace Adapter_1
{
    public class AudioPlayer : IMediaPlayer
    {
        private MediaAdapter _mediaAdapter;

        public void Play(string mediaType, string fileName)
        {
            if (mediaType == "mp3")
            {
                Console.WriteLine($"Воспроизводим mp3-файл. Имя файла: {fileName}");
            }
            else if (mediaType == "flac" || mediaType == "mkv")
            {
                _mediaAdapter = new MediaAdapter(mediaType);
                _mediaAdapter.Play(mediaType, fileName);
            }
            else
            {
                Console.WriteLine($"{mediaType} формат не поддерживается.");
            }
        }
    }
}