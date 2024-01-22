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
        public void Add(K key, V value)
        {

        }
        public void Remove(K key)
        {

        }
        public Dictionary<K, V> Filter()
        {

        }

    }
}
