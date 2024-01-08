namespace DAMLib
{
    public class Stack <T>
    {
        private T[] _stack;

        public void Push(T newElement)
        {

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
            int count = 0;
            for(int i = 0; i < _stack.Length; i++)
            {
                count++;
            }
            return count;
        }
    }
}
