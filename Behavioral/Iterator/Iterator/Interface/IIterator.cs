namespace Iterator.Interface
{
    internal interface IIterator<T>
    {
        T? CurrentNode();
        T? First();
        T? Next();
        void Reset();
    }
}
