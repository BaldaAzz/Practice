using System;

namespace N_1
{
    class MyList<T>
    {
        public int Length {get; private set;}
        protected T[] array = new T[0];

        public MyList() { }

        public MyList(T[] array)
        {
            this.array = array;
            this.Length = array.Length;
        }

        public T this[int index] 
        {
            get => array[index];
        }

        public void Add(T elem)
        {
            Array.Resize(ref this.array, this.array.Length + 1);
            this.Length = this.array.Length;

            array[this.Length - 1] = elem;
        }

        public static T[] GetArray<T>(MyList<T> list) => list.array;
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new();

            myList.Add(2);
            Console.WriteLine($"Под индексом 0 лежит {myList[0]}");

            myList.Add(5);
            Console.WriteLine($"Под индексом 1 лежит {myList[1]}");

            int[] arr = MyList<int>.GetArray(myList);

            foreach (var item in arr) Console.Write($"{item} ");
        }
    }
}