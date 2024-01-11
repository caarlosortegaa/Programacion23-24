namespace DAMLib
{
    public class Set<T>
    {
        T[] _set = new T[0];
        public int Count => _set.Length;
        public bool IsEmpty => _set.Length == 0;
        public void Add(T element)
        {
            T[] array = new T[_set.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = _set[i];
            }
            array[array.Length - 1] = element;
            _set = array;
        }
        public void Remove(T element)
        {
            T[] array = new T[_set.Length - 1];
            for (int i = 0; i < _set.Length - 1; i++)
            {
                array[i] = _set[i];
            }
           _set = array;
        }
    }
}
