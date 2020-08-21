using System;


namespace Adapter_1
{
    class Program
    {
        static void Main(string[] args)
        {
            AudioPlayer player = new AudioPlayer();
            player.Play("mp3", "Track-1");
            player.Play("mkv", "Track-2");
            player.Play("flac", "Track-3");
            player.Play("unknown", "Track-4");

            Console.ReadLine();
        }
    }
}