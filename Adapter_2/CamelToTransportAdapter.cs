namespace Adapter_2
{
    // Адаптер от Camel к ITransport
    class CamelToTransportAdapter : ITransport
    {
        private IAnimal _animal;

        public CamelToTransportAdapter(IAnimal animal)
        {
            _animal = animal;
        }

        public void Drive()
        {
            _animal.Move();
        }
    }
}