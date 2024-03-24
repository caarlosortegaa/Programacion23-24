namespace DAMLib
{
    public class Set<T> : Iset<T>
    {
        // Javi: pon private
        T[] _set = new T[0];

        public int Count => _set.Length;
        public bool IsEmpty => _set.Length == 0;

        public void Add(T element)
        {
            if (element == null)
                return;
            T[] array = new T[_set.Length + 1];
            // Javi: MAL!! Esto era lo primero que tenías que haber hecho
            if (!Contains(element))
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = _set[i];
                }
            }
            // Javi: Esto funciona mal
            array[_set.Length] = element;
            _set = array;
        }
        public void Remove(T element)
        {
            int indexValue = IndexOf(element);
            if (indexValue >= 0)
            {
                T[] array = new T[_set.Length - 1];
                for (int i = 0; i < indexValue; i++)
                    array[i] = _set[i];
                for(int i = indexValue + 1; i < _set.Length; i++)
                    _set = array; // Javi: MAL!!!!!!!!!!!!!!!!!!!!!!!!!
            }
        }
        public bool Contains(T element)
        {
            return IndexOf(element) >= 0; 
        }
        private int IndexOf(T element)
        {
            for (int i = 0; i < _set.Length; i++)
            {
                if (_set[i].Equals(element))
                    return i;
            }
            return -1;
        }
        public void clear()
        {
            _set = new T[0];
        }
    }
}
