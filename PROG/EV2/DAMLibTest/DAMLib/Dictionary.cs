namespace DAMLib
{
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
        public void Remove(K key)
        {
            int indexKey = IndexOf(key);
            if (indexKey >= 0)
            {
                item[] newItems = new item[_items.Length - 1];
                for (int i = 0; i < indexKey; i++)
                    newItems[i] = _items[i];
                for (int i = indexKey - 1; i < _items.Length; i++)
                    newItems[i] = _items[i];
                _items = newItems;
                
            }
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

    }
}
