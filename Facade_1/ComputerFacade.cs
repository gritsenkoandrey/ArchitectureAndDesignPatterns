namespace Facade_1
{
    public class ComputerFacade
    {
        protected Computer computer;

        public ComputerFacade(Computer computer)
        {
            this.computer = computer;
        }

        public void TurnOn()
        {
            this.computer.LightOnLed();
            this.computer.MakeSound();
            this.computer.ShowWelcomeScreen();
            this.computer.PlayOSReadySound();
        }

        public void TurnOff()
        {
            this.computer.CloseOpenedApplication();
            this.computer.TurnOffMonitor();
            this.computer.LightOffLed();
        }
    }
}