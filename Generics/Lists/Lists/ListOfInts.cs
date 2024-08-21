namespace Lists
{
    class ListOfInts
    {
        private int[] _items = new int[4];
        private int _size = 0;

        public void Add(int item)
        {
            if (_size >= _items.Length)
            {
                var newItems = new int[_items.Length * 2];

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

            _items[_size] = 0;
        }

        public int GetAtIndex(int index)
        {
            CheckOutOfRange(index);
            return _items[index];
        }

        public static void CheckOutOfRange(int index) => throw new IndexOutOfRangeException($"index {index} is not valide");
    }
}