using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class CustomList
    {
        private const int InitialCapacity = 2;
        private int[] array;

        public CustomList()
        {
            this.array = new int[InitialCapacity];
        }
        public int Count { get; private set; }

        public int this [int index] {
            get
            {
                if (index>=this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }

               return this.array[index];
            }
            set
            {
                if (index >= this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.array[index] = value;
            }
        }


        public void Add(int number)
        {
            if (this.Count==this.array.Length)
            {
                this.Resize();
            }


            this.array[this.Count] = number;
            Count++;
        }

        public int RemoveAt(int index)
        {
            if (index >= this.Count)
            {
                throw new ArgumentOutOfRangeException();
          
            }

            int number = this.array[index];
            this.array[index] = default(int);
            this.Shift(index);
            this.Count--;

            if (this.Count==this.array.Length/4)
            {
                this.Shrink();
            }

            return number;
        }

        public void Insert (int index, int number)
        {
            if (index>this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (this.Count==this.array.Length)
            {
                this.Resize();
            }

            this.ShiftRight(index);
            this.array[index] = number;
            this.Count++;
        }

        public bool Cantains (int number)
        {
            foreach (var item in this.array)
            {
                if (item==number)
                {
                    return true;
                }

            }
            return false;
        }

        public void Swaap(int first, int second)
        {

        }

        private void ShiftRight(int index)
        {
            for (int i = index; i > this.Count; i--)
            {
                this.array[i] = this.array[i - 1];
            }
        }

        private void Shrink()
        {
            int[] copy = new int[this.array.Length / 2];

            Array.Copy(this.array, copy, this.Count);

            this.array = copy;
        
        }

        private void Shift(int index)
        {
            for (int i = index; i < this.Count-1; i++)
            {
                this.array[i] = this.array[i + 1];
            }

            this.array[this.Count - 1] = 0;
        }

        private void Resize()
        {
            int[] copy = new int[this.array.Length * 2];

            for (int i = 0; i < this.array.Length; i++)
            {
                copy[i] = this.array[i];
            }

            this.array = copy;
        }
    }
}
