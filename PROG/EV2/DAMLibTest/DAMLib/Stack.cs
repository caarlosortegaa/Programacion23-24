namespace DAMLib
{
    public class Stack <T>
    {
        private T[] _stack = new T[0];

        public void Push(T newElement)
        {
            T[] newArray = new T[_stack.Length + 1];
            Array.Copy(_stack, newArray, _stack.Length);
            newArray[newArray.Length - 1] = newElement;
            _stack = newArray;
        }
        public T Pop()
        {
            if (IsEmpty())
                return default(T);
            T[] newStack = new T[_stack.Length - 2];
            for (int i = 0; i < _stack.Length - 2; i++)
            {
                newStack[i] = _stack[i];
            }
            return _stack[_stack.Length - 1];
        }
        public T GetTop()
        {
            return _stack[0];
        }
        public bool IsEmpty()
        {
            return GetCount() == 0;
        }
        public int GetCount()
        {
            return _stack.Length;
        }
    }
}
