using System;
using System.Collections.Generic;


namespace Observer_1
{
    public class ObservableMinerals : IObservable<Mineral>
    {
        private List<IObserver<Mineral>> _observers = new List<IObserver<Mineral>>();
        private Mineral _mineral;

        public Mineral Mineral
        {
            get { return _mineral; }
            set
            {
                _mineral = value;
                this.Notify(_mineral);
            }
        }

        /// <summary>
        /// Метод Subscribe позволяет наблюдателю подписаться на события поставщика.
        /// </summary>
        public IDisposable Subscribe(IObserver<Mineral> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
            return new Unsubsciber(_observers, observer);
        }

        /// <summary>
        /// Метод Notify оповещает наблюдателей о изменении свойств.
        /// </summary>
        /// <param name="mineral"></param>
        private void Notify(Mineral mineral)
        {
            foreach (var observer in _observers)
            {
                if (mineral.Name == null || mineral.Price < 0)
                {
                    observer.OnError(new Exception("Неправильные данные"));
                }
                else
                {
                    observer.OnNext(Mineral);
                }
            }
        }

        /// <summary>
        /// Метод Stop позволяет прекратить торги на бирже.
        /// </summary>
        public void Stop()
        {
            foreach (var observer in _observers)
            {
                if (_observers.Contains(observer))
                {
                    observer.OnCompleted();
                }
            }
            _observers.Clear();
        }

        /// <summary>
        /// Класс Unsubscriber хранит в себе список наблюдателей.
        /// </summary>
        private class Unsubsciber : IDisposable
        {
            private List<IObserver<Mineral>> _observers;
            private IObserver<Mineral> _observer;

            public Unsubsciber(List<IObserver<Mineral>> observers, IObserver<Mineral> observer)
            {
                _observers = observers;
                _observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                {
                    _observers.Remove(_observer);
                }
            }
        }
    }
}