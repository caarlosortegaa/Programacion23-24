namespace DAMLib
{
    // Javi: ISet
    public interface Iset<T>
    {
        int Count { get; }
        bool IsEmpty { get; }

        void Add(T element);
        void Remove(T element);
        bool Contains (T element);
        // Javi: Minúsculas?
        void clear();
    }
}
