﻿using DAMLib;
using System.Collections.Generic;

namespace DamLib
{
    public class ItemSet<T> : Iset<T>
    {
        private class Item
        {
            public T element;
            public int hash;

            public Item(T element)
            {
                this.element = element;
                this.hash = element.GetHashCode();
            }
        }
        private Item[] _items = new Item[0];

        public int Count => _items.Length;
        public bool IsEmpty => _items.Length == 0;

        public void Add(T element)
        {
            if (element == null)
                return;
            if (!Contains(element))
            {
                Item lastItem = new Item(element);
                Item[] aux = new Item[_items.Length + 1];
                for (int i = 0; i < _items.Length; i++)
                {
                    aux[i] = _items[i];
                }
                aux[_items.Length] = lastItem;
                _items = aux;
            }
        }
        public void Remove(T element)
        {
            int indexelement = Indexof(element);
            if (indexelement >= 0)
            {
                Item[] aux = new Item[_items.Length - 1];
                for (int i = 0; i < indexelement; i++)
                    aux[i] = _items[i];
                for (int i = indexelement - 1; i < _items.Length - 1; i++)
                    aux[i] = _items[i];
                _items = aux;
            }
        }
        // Javi: IndexOf
        private int Indexof(T element)
        {
            if (element == null)
                return -1;
            int elementHash = element.GetHashCode();
            for (int i = 0; i < _items.Length; i++)
            {
                if (elementHash == _items[i].hash && _items[i].element.Equals(element))
                    return i;
            }
            return -1;

        }
        public bool Contains(T element)
        {
            return Indexof(element) >= 0;
        }

        public void clear()
        {
            _items = new Item[0];
        }
    }
}
