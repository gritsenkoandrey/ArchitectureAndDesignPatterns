namespace Adapter_1
{
    public class MediaAdapter : IMediaPlayer
    {
        private IModernMediaPlayer _modernMusicPlayer;

        public MediaAdapter(string mediaType)
        {
            if (mediaType == "flac" || mediaType == "mkv")
            {
                _modernMusicPlayer = new AIMP();
            }
        }

        public void Play(string mediaType, string fileName)
        {
            if (mediaType == "flac")
            {
                _modernMusicPlayer.PlayFlac(fileName);
            }
            else if (mediaType == "mkv")
            {
                _modernMusicPlayer.PlayMkv(fileName);
            }
        }
    }
}