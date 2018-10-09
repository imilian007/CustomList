using System;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> items = new GenericList<int>();
            items.Add(4);


            Console.WriteLine("Hello World! {0}", items);
        }
    }
}
