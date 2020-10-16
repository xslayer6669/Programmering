using System;

namespace Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog minhund = new Dog(5);
            minhund.Act();

            Cat minkatt = new Cat(5);
            minkatt.Act();
        }
    }
}

