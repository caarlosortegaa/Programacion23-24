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
            if (!Contains(element))
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = _set[i];
                }
            }
            array[array.Length - 1] = element;
            _set = array;
        }
        public void Remove(T element)
        {
            int indexValue = IndexOf(element);
            if (indexValue != -1)
            {
                T[] array = new T[_set.Length - 1];
                for (int i = 0; i < _set.Length; i++)
                {
                    if(indexValue != i)
                    {
                        array[i] = _set[i];
                    }
                }

                _set = array;
            }
        }
        public bool Contains(T element)
        {
            if(IndexOf(element) != -1) 
                return true;
            return false;
        }
        public int IndexOf(T element)
        {
            for (int i = 0; i < _set.Length; i++)
            {
                if (_set[i].Equals(element))
                    return i;
            }
            return -1;
        }
    }
}
