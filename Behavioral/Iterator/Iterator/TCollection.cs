using Iterator.Interface;

namespace Iterator
{
    internal class TCollection<T>
    {
        private readonly List<T> _items = new();
        public TCollection<T> Add(T item) 
        { 
            _items.Add(item); 
            return this; 
        }
        public IIterator<T> GetIterator() => new Iterators<T>(_items);
    }
}
