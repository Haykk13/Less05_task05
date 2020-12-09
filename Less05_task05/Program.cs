using System;

namespace Less05_task05
{
    class Program
    {
        static void Main(string[] args)
        {
            Base inst1 = new Base();
            Console.WriteLine(inst1[2]);

            Base inst2 = new Derived();
            Console.WriteLine(inst2[2]);

            Console.ReadKey();
        }
    }

    class Base
    {
        private int[] arr = new int[] { 1, 2, 3, 4, 5 };
        public virtual int this[int index]
        {
            get
            {
                return arr[index];
            }
        }

    }

    class Derived : Base
    {
        private int[] arr = new int[] { 6, 7, 8, 9, 10 };
        public override int this[int index]
        {
            get
            {
                return base[index] + arr[index];
            }
        }
    }
}