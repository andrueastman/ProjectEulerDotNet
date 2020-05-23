using System;

namespace Project_Euler
{
    public class List<T>
    {
        private int _capacity;
        private T[] _values = { };

        public void Add(T item)
        {
            var newValues = new T[_capacity + 1];

            // TODO this may not be good
            for (var i = 0; i < _capacity; i++) newValues[i] = _values[i];

            newValues[_capacity] = item;
            _values = newValues;
            _capacity++;
        }

        public T[] ToArray()
        {
            return _values;
        }

        public List<T> Where(Func<T, bool> p)
        {
            var results = new List<T>();
            for (var i = 0; i < _capacity; i++)
                if (p.Invoke(_values[i]))
                    results.Add(_values[i]);

            return results;
        }
    }
}