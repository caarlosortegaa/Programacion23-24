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
            return _stack[_stack.Length - 1];
        }
        public T GetTop()
        {
            return _stack[0];
        }
        public bool IsEmpty()
        {

        }
        public int GetCount() => _stack.Length;
    }
}
