using System;

namespace N_2
{
    class MyDictionary<TKey, TValue>
    {
        private TKey[] keys = new TKey[0];
        private TValue[] values = new TValue[0];

        public int Length {get; private set;}

        public MyDictionary() => this.Length = keys.Length;

        public TValue this[TKey key]
        {
            get => this.values[Array.IndexOf(this.keys, key)];
        }

        public void Add(TKey key, TValue value)
        {
            Array.Resize(ref this.keys, this.Length + 1);
            Array.Resize(ref this.values, this.Length + 1);

            this.Length = keys.Length;

            keys[^1] = key;
            values[^1] = value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> dict = new();

            dict.Add("one", 1);
            System.Console.WriteLine(dict["one"]);
        }
    }
}