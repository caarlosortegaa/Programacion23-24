namespace DAMLib
{
    public class Queue <T>
    {
        private T[] _queue = new T[0];
        public int Count => _queue.Length;
        public bool Empty => _queue.Length == 0;
        public T First
        {
            get
            {
                if (Empty)
                    return default(T);
                return _queue[0];
            }
        }
        public T Last
        {
            get
            {
                if (Empty)
                    return default(T);
                return (_queue[_queue.Length - 1]);
            }
        }

        public void EnQueue(T element)
        {
            T[] array = new T[_queue.Length + 1];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = _queue[i];
            }
            array[array.Length - 1] = element;
            _queue = array;
        }
        public T Dequeue()
        {
            T[] array = new T[_queue.Length - 1];
            T value = _queue[0];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = _queue[i + 1];
            }
            _queue = array;
            return value;
        }
        public void Clear()
        {
            _queue = new T[0];
        }

    }
}
