using System.Collections;

namespace Module3HW1
{
    internal class CustomList<T> : IEnumerable<T>
    {
        private const int Capacity = 4;
        private const int UpCapacity = 2;
        private T[] ? _array = new T[Capacity];
        public int Count { get; private set; }

        public void Add(T value)
        {
            if (Count >= _array.Length)
            {
                Array.Resize(ref _array, _array.Length * UpCapacity);
            }

            _array[Count] = value;
            Count++;
        }

        public void AddRange(Array array)
        {
            Array.Resize(ref _array, _array.Length + array.Length);
            Count += array.Length;
            array.CopyTo(_array, Count - array.Length);
        }

        public bool Remove(T item)
        {
            var result = false;
            var index = Array.IndexOf(_array, item, 0, Count);
            if (index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            for (var i = index; i < Count - 1; i++)
            {
                if (_array[i].Equals(item))
                    {
                    T? def = default;
                    _array[i] = def;
                    result = true;
                }
            }

            return result;
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < _array.Length; i++)
            {
                if (i == index)
                {
                    _array[i] = default;
                }
            }
        }

        public void Sort(IComparer<T> comparer)
        {
            Array.Sort(_array, comparer);
        }

        public void Clear()
        {
            _array = default;
        }

        public IEnumerator<T> GetEnumerator()
        {
            try
            {
                return (_array as IEnumerable<T>).GetEnumerator();
            }
            catch (NullReferenceException)
            {
                throw new NullReferenceException("Collection is empty");
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _array.GetEnumerator();
        }
    }
}
