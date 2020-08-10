namespace Singleton_2
{
    public class OS
    {
        private static OS _instance;

        public string Name { get; private set; }

        //для многопоточного режима
        private static object syncRoot = new object();

        protected OS( string name)
        {
            Name = name;
        }

        //public static OS GetInstance(string name)
        //{
        //    if (_instance == null)
        //        _instance = new OS(name);
        //    return _instance;
        //}

        //для многопоточного режима
        public static OS GetInstance(string name)
        {
            if (_instance == null)
            {
                //Чтобы избежать одновременного доступа к коду из разных
                //потоков критическая секция заключается в блок lock.
                lock (syncRoot)
                {
                    if (_instance == null)
                    {
                        _instance = new OS(name);
                    }
                }
            }
            return _instance;
        }
    }
}