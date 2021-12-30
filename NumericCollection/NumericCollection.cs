using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NumericCollection
{
    public class NumericCollection<T>:IList<T> where T : struct, IComparable<T>
    {
        private T[] _items = Array.Empty<T>();
        private T? _maxValue;
        private int _size;
        private const int DefaultCapacity = 4;
        private int _capacity;
        private const string MaxValueMessage = "Trying to find the maximum value in an empty collection";
        private const string NonNumericMessage = "Attempting to create a non-numeric collection";
        private const string ItemNotFoundMessage = "Attempting to find an object that is not in the collection";

        private readonly Type[] _numericTypes = new[]
        {
            typeof(Int16),
            typeof(Int32),
            typeof(Int64),
            typeof(SByte),
            typeof(Byte),
            typeof(UInt16),
            typeof(UInt32),
            typeof(UInt64),
            typeof(Single),
            typeof(Double),
            typeof(Decimal)
        };

        public NumericCollection()
        {
            if (!_numericTypes.Contains(typeof(T)))
            {
                throw new Exception(NonNumericMessage);
            }   
        }
    
        public int Capacity => _capacity;
        public T? MaxValue
        {
            get
            {
                if (!_maxValue.HasValue)
                {
                    throw new Exception(MaxValueMessage);
                }
                return _size == 1 ? _items[0] : _maxValue;
            }
        }

        public T this[int index]
        {
            get => _items[index];
            set => _items[index] = value;
        }

        public int Count => _size;
        public bool IsReadOnly { get; }

        public void Add(T item)
        {
            int size = _size;
            if (size < _items.Length)
            {
                _items[size] = item;
            }
            else
            {
                Grow(size + 1);
                Array.Resize(ref _items, Capacity);
                _items[size] = item;
            }
            if(!_maxValue.HasValue || (_maxValue != null && (_maxValue.Value.CompareTo(item) < 0) ))
            {
                _maxValue = item;
            }
            _size++;
        }
    
        private void Grow(int capacity)
        {
            int newCapacity = _items.Length == 0 ? DefaultCapacity : 2 * _items.Length;

            // Allow the list to grow to maximum possible capacity (~2G elements) before encountering overflow.
            // Note that this check works even when _items.Length overflowed thanks to the (uint) cast
            if ((uint) newCapacity > Array.MaxLength) newCapacity = Array.MaxLength;

            // If the computed capacity is still less than specified, set to the original argument.
            // Capacities exceeding Array.MaxLength will be surfaced as OutOfMemoryException by Array.Resize.
            if (newCapacity < capacity) newCapacity = capacity;

            _capacity = newCapacity;
        }

        public int IndexOf(T item)
            => Array.IndexOf(_items, item, 0, _size);

        public void Insert(int index, T item)
        {
            int size = _size;
            if ((uint) index > (uint) size)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (size == _capacity)
            {
                Grow(size + 1);
                Array.Resize(ref _items, _capacity);
            }

            if (index < size)
            {
                Array.Copy(_items, index, _items, index + 1, size - index);
            }

            _items[index] = item;
            _size++;
        }

        public void RemoveAt(int index)
        {
            int size = _size;
            if ((uint) index > (uint) size)
            {
                throw new ArgumentOutOfRangeException();
            }
            T tmpMaxValue = default;
            for (int i = 0; i < size; i++)
            {

                if (i >= index && i < size-1)
                {
                    _items[i] = _items[i + 1];
                }
                if (tmpMaxValue.CompareTo(_items[i]) < 0 && i!=index)
                {
                    tmpMaxValue = _items[i];
                }
            }
            _items[size-1] = default;
            _maxValue = tmpMaxValue;
            _size--;
        }

        public bool Remove(T item)
        {
            var index = IndexOf(item);
            if (index >= 0)
            {
                RemoveAt(index);
                return true;
            }
            if (index == -1)
            {
                throw new Exception(ItemNotFoundMessage);
            }
            return false;
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _size; i++)
                yield return _items[i];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}