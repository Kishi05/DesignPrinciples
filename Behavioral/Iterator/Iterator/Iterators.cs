#nullable enable

using Iterator.Interface;

namespace Iterator
{
    internal class Iterators<T> : IIterator<T>
    {
        private readonly List<T> _items;
        private int index = 0;

        private bool IsEmpty
        {
            get
            {
                return _items.Count == 0;
            }
        }

        private bool IsEnd
        {
            get
            {
                return index >= _items.Count;
            }
        }

        public Iterators(IEnumerable<T> enumerable)
        { 
            _items = enumerable?.ToList() ?? new List<T>();
        }

        public T? CurrentNode()
        {
            if (IsEmpty) 
                throw new InvalidOperationException("Collection is empty.");

            if (IsEnd)
                throw new InvalidOperationException("Reached the end of the list.");
            int indexValue = index > 0 ? index-1 : index;
            return _items[indexValue];
        }

        public T? First()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Collection is empty.");

            index = 0;
            return _items.FirstOrDefault();
        }

        

        public T? Next()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Collection is empty.");

            if (IsEnd)
                throw new InvalidOperationException("Reached the end of the list.");

            return _items[index++];
        }

        public void Reset() => index = 0;

    }
}
