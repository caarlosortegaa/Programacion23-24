using System.ComponentModel;

namespace Prueba4
{
    public delegate bool FilterDelegate<T>(T elemenent);
    public delegate void VisitDelegate<T>(T element); 
    public delegate int SortDelegate<T>(T element, T element2);

    public class ExList<T>
    {
        private T[] _elements = new T[0];
        public int Count {  get { return _elements.Length; } }
        public T First => _elements.Length > 0 ? _elements[0] : throw new Exception("lista vacía");
        public T Last => _elements.Length > 0 ? _elements[_elements.Length - 1] : throw new Exception("lista vacía");
        public T[] Reversed { get { return Reverse(); } }

        public T[] Reverse()
        {
            T[] newElements = new T[_elements.Length];
            for(int i = 0; i < _elements.Length; i++)
            {
                newElements[i] = _elements[_elements.Length - 1 - i ];
            }
            return newElements;
        }

        public T? GetElementAt(int index)
        {
            if (index >= 0 && index < _elements.Length)
                return _elements[index];
            return default(T);
        }
        public void SetElementAt(int index, T value)
        {
            if (index >= 0 && index < _elements.Length)
                _elements[index] = value; 
        }
        public void AddElement(T value)
        {
            T[] newArray = new T[_elements.Length + 1];
            for(int i = 0; i < _elements.Length; i++)
            {
                newArray[i] = _elements[i];
            }
            newArray[newArray.Length - 1] = value;
            _elements = newArray;
        }
        public void RemoveAt(int index)
        {
            if (index < 0 && index >= _elements.Length)
                return;
            T[] values = new T[_elements.Length - 1];
            for (int i = 0, j = 0; i < _elements.Length; i++)
            {
                if (i != index)
                {
                    values[j] = _elements[i];
                    j++;
                }
            }
            _elements = values;
        }
    
        public void Clear()
        {
            _elements = new T[0];
        }
        public void Insert(int index, T value)
        {
            if (index <= 0 || index > _elements.Length)
                return;
            T[] newArray = new T[_elements.Length + 1];
            for(int i = 0; i < index; i++)
                newArray[i] = _elements[i];
            newArray[index] = value;
            for (int i = index; i < _elements.Length; i++)
                newArray[i + 1] = _elements[i];
            _elements = newArray;
        }
        public int IndexOf(T value)
        {
            if(value == null)
                return -1;
            for(int i = 0; i < _elements.Length; i++)
            {
                if (_elements[i] != null)
                {
                    if (_elements[i].Equals(value))
                        return i;
                }
            }
            return -1;
        }
        public bool Contains(T element)
        {
            return IndexOf(element) != 1;
        }
        public ExList<T> Clone()
        {
            return new ExList<T>
            {
                _elements = new T[_elements.Length]
            };
            
           
        }
        public T[] ToArray()
        {
            T[] newArray = new T[_elements.Length];
            for(int i = 0; i < _elements.Length; i++)
            {
                newArray[i] = _elements[i];
            }
            return newArray;
        }
        public T[] Filter(FilterDelegate<T> filter)
        {       
            ExList<T> ex = new ExList<T> ();
            for(int i = 0; i < _elements.Length; i++)
            {
                if (filter(_elements[i]))
                    ex.AddElement(_elements[i]);

            }
            return ex._elements; 
        }
        public void Visit(VisitDelegate<T> visitor)
        {
            if (visitor == null)
                return;
            for (int i = 0; i < _elements.Length; i++)
                visitor(_elements[i]);
        }

        public void Sort(SortDelegate<T> sort)
        {
            if (sort == null)
                return;
            for (int i = 0; i < _elements.Length - 1; i++)
            {
                for (int j = i + 1; j < _elements.Length; j++)
                {
                    if (sort(_elements[i], _elements[j]) > 0)
                    {
                        T aux = _elements[i];
                        _elements[i] = _elements[j];
                        _elements[j] = aux;
                    }
                }
            }
        }
    }
}
