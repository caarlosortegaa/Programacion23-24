namespace DAMLib
{
    public delegate bool DictionaryFilter<K,V>(K key, V value);
    public class Dictionary<K, V>
    {
        private class item
        {
            public K key;
            public V value;

            public item(K key, V value)
            {
                this.key = key;
                this.value = value;
            }
        }
        item[] _items = new item[0];
        
        
        public int count => _items.Length;
        public bool IsEmpty => _items.Length == 0;
        
        public bool Add(K key, V value)
        {
            if (key == null || value == null ||contains(key))
                return false;
            item[] newItems = new item[_items.Length + 1];
            item newitem = new item(key, value);
            for(int i = 0; i < _items.Length; i++)
            {
                newItems[i] = _items[i];
            }
            newItems[_items.Length] = newitem;
            _items = newItems;
            return true; 
        }
        public bool contains(K key)
        {
            return IndexOf(key) >= 0;
        }

        public int IndexOf(K key)
        {
            if (key == null)
                return -1;
            for(int i = 0; i < _items.Length; i++)
            {
                if (_items[i].key.Equals(key))
                    return i;
            }
            return -1;
        }
        public void clear()
        {
            _items = new item[0];
        }
        public Dictionary<K, V> Filter(DictionaryFilter<K, V> del)
        {
            Dictionary<K, V> result = new Dictionary<K, V>();
            for (int i = 0; i < _items.Length; i++)
            {
                item item = _items[i];
                bool found = del(item.key, item.value);
                if (found)
                    result.Add(item.key, item.value);
            }
            return result;
        }
        public void Remove(Dictionary<K,V> del)
        {
            for(int i = 0; i < _items.Length; i++)
            {
                item item= _items[i];

            }
        }

    }
}
