using System;


namespace Facade_1
{
    public class Computer
    {
        public void LightOnLed() => Console.WriteLine("Light on!");
        public void MakeSound() => Console.WriteLine("Beep!");
        public void ShowWelcomeScreen() => Console.WriteLine("Loading OS!");
        public void PlayOSReadySound() => Console.WriteLine("Ready to be used!");
        public void CloseOpenedApplication() => Console.WriteLine("Close window!");
        public void TurnOffMonitor() => Console.WriteLine("Turn off monitor!");
        public void LightOffLed() => Console.WriteLine("Light off");
    }
}