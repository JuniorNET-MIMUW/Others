using System;
using System.Collections;
using System.Collections.Generic;

namespace Rational
{
    class List<T> : IList<T>
    {
        private class ListElement
        {
            public T Element { get; }

            public ListElement(T elem)
            {
                Element = elem;
            }
        }

        private int lastElement;
        private ListElement[] array = new ListElement[10];

        public List(bool isReadOnly = false)
        {
            IsReadOnly = isReadOnly;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var t in array)
            {
                if(t == null) continue;
                yield return t.Element;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            if (!IsReadOnly) array = new ListElement[10];
        }

        public bool Contains(T item)
        {
            foreach (var elem in array)
            {
                if (elem.Equals(item)) return true;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            int i = arrayIndex;
            foreach (var elem in array)
            {
                array[i] = elem;
            }
            /*
            for (i = 0; i < this.array.Length; i++)
            {
                array[arrayIndex + i] = this.array[i].Element;
            }*/
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public int Count => array.Length;
        public bool IsReadOnly { get; }
        public int IndexOf(T item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(item)) return i;
            }
            return -1;
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public T this[int index]
        {
            get
            {
                if(index > lastElement)
                    throw new IndexOutOfRangeException();
                ListElement element = array[index];
                if (element == null)
                    throw new ArgumentException("Element with given index does not exists");
                return element.Element;
            }
            set
            {
                if (index > lastElement)
                    throw new IndexOutOfRangeException();
                ListElement element = array[index];
                array[index] = new ListElement(value);
            }
        }

        private void Expand()
        {
            var newArray = new ListElement[array.Length*2];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }
    }
}
