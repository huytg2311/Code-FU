using System;

namespace Demo02
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string msg = "Multicast Delegate";
            Mydelegate MyDele01 = MyClass.Print;
            Mydelegate MyDele02 = MyClass.Show;
            Console.WriteLine("***Combines MyDele01 + MyDele02***");
            Mydelegate MyDele = MyDele01 + MyDele02;
            MyDele(msg);
            Console.WriteLine("***Combines MyDele01 + MyDele02 + MyDele03***");
            Mydelegate MyDele03 = MyClass.Display;
            MyDele += MyDele03;
            MyDele(msg);
            Console.WriteLine("-----------------------");
            Console.WriteLine("****Remove MyDele02*****");
            MyDele -= MyDele02;
            MyDele("Hello World");
            Console.ReadLine();
        }
    }
}
