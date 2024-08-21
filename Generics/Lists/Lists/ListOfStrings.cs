using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class ListOfStrings
    {
        private string[] _items = new string[4];
        private int _size = 0;

        public void Add(string item)
        {
            if (_size >= _items.Length)
            {
                var newItems = new string[_items.Length * 2];

                for (int i = 0; i < _items.Length; i++)
                {
                    newItems[i] = _items[i];
                }

                _items = newItems;
            }

            _items[_size] = item;
            ++_size;
        }

        public void RemoveAt(int index)
        {
            CheckOutOfRange(index);

            --_size;

            for (int i = index; i < _size; i++)
            {
                _items[i] = _items[i + 1];
            }

            _items[_size] = null;
        }

        public string GetAtIndex(int index)
        {
            CheckOutOfRange(index);
            return _items[index];
        }

        public static void CheckOutOfRange(int index) => throw new IndexOutOfRangeException($"index {index} is not valide");
    }
}
