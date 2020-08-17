using System.Collections;
using System.Collections.Generic;


namespace Iterator_1
{
    public class ItemCollection<T> : IEnumerable<T>
    {
        private List<T> _items = new List<T>();
        public int Count => _items.Count;

        public IEnumerable<T> FrontToBack => this;

        public IEnumerable<T> BackToFront
        {
            get
            {
                for (int i = Count - 1; i >= 0; i--)
                {
                    yield return _items[i];
                }
            }
        }

        public void Add(T t)
        {
            _items.Add(t);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return _items[i];
            }
        }

        public IEnumerable<T> FromToStep(int from, int to, int step)
        {
            for (int i = from; i <= to; i = i + step)
            {
                yield return _items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}