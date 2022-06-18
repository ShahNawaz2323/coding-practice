using System;

namespace Basic
{
    public class Nullable<T> where T : struct
    {
        private object _value;

        public Nullable(T value)
        {
            _value = Value;
        }

        public bool HasValue
        {
            get{ return _value != null;}
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T) _value;
            return default(T);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var number = new Nullable<int>(5);
            System.Console.WriteLine("Has Value" + number.HasValue);
            System.Console.WriteLine("Value : " + number);
        }
    }
}
