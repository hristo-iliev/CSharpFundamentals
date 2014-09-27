////TASK 5
////Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. ...

////TASK 6
////Implement auto-grow functionality: when the internal array is full, create a new array of double size
////and move all elements to it.

namespace Euclidian3DSpace
{
    using System;
    using System.Text;

    public class GenericList<T>
    {
        private const int DefaultLenght = 16;

        private T[] data;
        private int index;

        public GenericList() : this(DefaultLenght)
        {
        }

        public GenericList(int count)
        {
            this.data = new T[count];
            this.index = 0;
        }

        public int Count
        {
            get
            {
                return this.index;
            }
        }

        public T this[int indexator]
        {
            get
            {
                if (indexator < 0 || indexator >= this.data.Length)
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }

                return this.data[indexator];
            }

            set
            {
                if (indexator < 0 || indexator >= this.data.Length)
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }

                this.data[indexator] = value;
            }
        }        

        public void Add(T value)
        {
            if (this.index == this.data.Length)
            {
                this.data = this.Resize(this.data);
            }

            this.data[this.index] = value;
            this.index++;
        }

        public void RemoveAt(int indexator)
        {
            if (indexator < 0 || indexator >= this.data.Length)
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }

            for (int i = indexator; i < this.data.Length - 1; i++)
            {
                this.data[i] = this.data[i + 1];
            }

            this.data[this.data.Length - 1] = default(T);
            this.index--;
        }

        public void InsertAt(int indexator, T value)
        {            
            T[] arr = new T[this.data.Length + 1];

            int j = 0;
            for (int i = 0; i < this.data.Length; i++)
            {
                if (i == indexator)
                {
                    arr[j] = value;
                    j++;
                }

                arr[j] = this.data[i];
                j++;
            }

            this.data = arr;
            this.index++;
        }

        public void Clear()
        {
            for (int i = 0; i < this.data.Length; i++)
            {
                this.data[i] = default(T);
            }

            this.index = 0;
        }

        public int FindPosition(T value)
        {
            int position = Array.IndexOf(this.data, value);
            return position;
        }

        public override string ToString()
        {
            var print = new StringBuilder();

            for (int i = 0; i < this.data.Length; i++)
            {
                print.Append(this.data[i] + ", ");
            }

            return print.ToString();
        }

        private T[] Resize(T[] current)
        {
            T[] newArr = new T[this.data.Length * 2];

            for (int i = 0; i < this.data.Length; i++)
            {
                newArr[i] = this.data[i];
            }

            return newArr;
        } 
    }
}
