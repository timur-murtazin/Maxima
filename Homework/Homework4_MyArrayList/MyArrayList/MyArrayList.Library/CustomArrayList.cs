using System.Xml.Linq;
using System;

namespace MyArrayList.Library
{
    public class CustomArrayList<T>
    {
        private T[] _array;
        private int _length;

        public int Count { get; private set; }

        public CustomArrayList()
        {
            _array = new T[4];
            _length = _array.Length;
        }

        public CustomArrayList(T element)
        {
            _array = new T[4];
            _array[0] = element;

            _length = _array.Length;
            Count++;
        }

        public CustomArrayList(T[] elements)
        {
            int arrayLength = (int)((elements.Length * 1.5) + elements.Length);
            _array = new T[arrayLength];

            for (int i = 0; i < elements.Length; i++)
            {
                _array[i] = elements[i];
                Count++;
            }

            _length = _array.Length;
        }

        /// <summary>
        /// Добавление одного элемента
        /// </summary>
        /// <param name="element"></param>
        public void Add(T element)
        {
            _array[Count] = element;
            Count++;
        }

        /// <summary>
        /// Добавление массива элементов
        /// </summary>
        /// <param name="element"></param>
        public void Add(T[] element)
        {
            int temp = default;
            int temp2 = default;

            for(int i = 0; i < Count; i++)
            {
                temp = _array[i];
                _array[i] = element[i];
                temp2 = _array[i + 1];
                _array[i + 1] = temp;
            } 
        }

        /// <summary>
        /// Добавление элемента по индексу
        /// </summary>
        /// <param name="element"></param>
        public void Add(int element, int index)
        {
            int[] newArray = new int[_array.Length + 1];

            newArray[index] = element;

            for (int i = 0; i < index; i++)
            {
                newArray[i] = _array[i];
            }
            
            for (int i = index + 1; i < newArray.Length; i++)
            {
                newArray[i] = _array[i];
            }

        }

        /// <summary>
        /// Добавление массива элементов по индексу
        /// </summary>
        /// <param name="element"></param>
        public void Add(int[] element, int index)
        {
            int[] newArray = new int[_array.Length + element.Length];
            int n = 0;

            for (int i = index; i < index + element.Length; i++)
            {
                newArray[i] = element[n];
                n++;
            }

            for (int i = 0; i < index; i++)
            {
                newArray[i] = element[i];
            }

            for (int i = index + 1; i < newArray.Length; i++)
            {
                newArray[i] = _array[i];
            }
        }

        /// <summary>
        /// Сортировка любым алгоритмом (кроме пузырьковой)
        /// </summary>
        /// <param name="element"></param>
        public void Sort()
        {
            int j = default;
            int cur = default;

            for (int i = 1; i < _array.Length; i++)
            {
                cur = _array[i];
                j = i;
                while (j > 0 && cur < _array[j - 1])
                {
                    _array[j] = _array[j - 1];
                    j--;
                }
                _array[j] = cur;
            }
        }

        /// <summary>
        /// Изменить размер массива
        /// </summary>
        private void Resize()
        {
            int num = Count;
            int[] resizeArray = new int[_array.Length + num];

        }
    }
}
