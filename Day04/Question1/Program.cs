using System;

namespace Question1
{
    class Program
    {
        private class ExampleClass { }
        static void Main(string[] args)
        {
            // list of type int
            GenericList<int> list1 = new GenericList<int>();
            list1.Add(1);

            // list of type string
            GenericList<string> list2 = new GenericList<string>();
            list2.Add("");

            // list of type ExampleClass
            GenericList<ExampleClass> list3 = new GenericList<ExampleClass>();
            list3.Add(new ExampleClass());
        }
    }
    public class GenericList<T> {
        public void Add(T input) { }
    }
}
