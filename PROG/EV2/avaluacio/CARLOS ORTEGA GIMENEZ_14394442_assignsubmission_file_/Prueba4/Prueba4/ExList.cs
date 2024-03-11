namespace Prueba4
{
    public delegate bool FilterDelegate<T>(T elemenent);
    public delegate void VisitDelegate<T>(T[] list); // Javi: Esto no debería ser una lista
    public delegate void SortDelegate<T>(T[] list);

    public class ExList<T>
    {
       private T[] _elements = new T[0];
        public int Count {  get { return _elements.Length; } }
        public T First { 
            get 
            {
                // Javi: Mal
                if (_elements[0] != null)
                    return _elements[0];
                throw new Exception("El primer valor no es válido");

            } 
        }
        public T Last
        {
            get
            {
                // Javi: Mal
                if (Count != 0 || _elements[_elements.Length - 1] != null)
                    return _elements[_elements.Length - 1];
                throw new Exception("Error");
            }
        }
        public T[] Reversed { get { return Reverse(); } }

        public T[] Reverse()
        {
            T[] newElements = new T[_elements.Length];
            // Javi: Mal
            for (int i = _elements.Length - 1; i >= 0; i--)
                _elements[i] = newElements[i];
            
            return newElements;
        }

        public T? GetElementAt(int index)
        {
            // Javi: MAL!!!!!!!!!!!!!
            if (index >= 0 || index <= _elements.Length)
                return _elements[index];
            return default(T);
        }
        public void SetElementAt(int index, T value)
        {
            // Javi: MAL!!!!!!!!!!!!!!!!!!!!!!
            if (index >= 0 ||index <= _elements.Length)
            _elements[index] = value;
        }
        public void AddElement(T value)
        {
            T[] newArray = new T[_elements.Length + 1];
            for(int i = 0; i < _elements.Length; i++)
            {
                _elements[i] = newArray[i];
            }
            newArray[newArray.Length - 1] = value;
            _elements = newArray;
        }
        public void RemoveAt(int index)
        {
            // Javi: Si te paso un -1, esto funciona?!?!?!?
            T[] newArray = new T[_elements.Length - 1];
            for(int i = 0; i < index;i++)
                newArray[i] = _elements[i];
            // Javi: Creo que esto no va bien
            for (int i = index; i < _elements.Length- 2;i++)
                newArray[i] = _elements[i + 1];
            _elements = newArray;
        }
        public void Clear()
        {
            _elements = new T[0];
        }
        public void Insert(int index, T value)
        {
            if (index <= 0 || index <= _elements.Length)
                return;
            T[] newArray = new T[_elements.Length - 1];
            // Javi: Por favor, tabula bien
                for(int i = 0;i < index; i++)
                    newArray[i] = _elements[i];
                newArray[index] = value;
                for (int i = index + 1; i < _elements.Length + 1; i++)
                    newArray[i] = _elements[i + 1];
            _elements = newArray;
        }
        public int IndexOf(T value)
        {
            if(value == null)
                return -1;
            for(int i = 0; i < _elements.Length; i++)
            {
                // Javi: No te lo voy a tener en cuenta, ..., pero y si _elements[i] es null??
                if (_elements[i].Equals(value))
                return i;
            }
            return -1;
        }
        // Javi: Función duplicada
        public bool Contains(T element)
        {
            for(int i = 0; i < _elements.Length; i++)
            {
                if (_elements[i].Equals(element))
                    return true;
            }
            return false;
        }
        public ExList<T> Clone()
        {
            ExList<T> clone = new ExList<T>();
            // Javi: Mal
            for (int i = 0; i < _elements.Length; i++)
            {
                clone._elements[i] = _elements[i];
            }
            return clone;
        }
        public T[] ToArray()
        {
            T[] newArray = new T[_elements.Length];
            for(int i = 0; i < _elements.Length; i++)
            {
                _elements[i] = newArray[i];
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
            // Javi: mmmm, si que podría funcionar
            return ex._elements; 
        }
        public void Visit(VisitDelegate<T> visitor)
        {
            
        }
        public void Sort(SortDelegate<T> sort)
        {
            
        }


    }
}
