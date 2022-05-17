using System;

delegate T NumberChanger<T>(T n);
namespace Question3
{
    class Program
    {
        static int num = 10;
        public static int AddNum(int p) {
            num += p;
            return num;
        }
        public static int MultNum(int q) {
            num *= q;
            return num;
        }
        public static int getNum() {
            return num;
        }
        static void Main(string[] args)
        {
            NumberChanger<int> nc1 = new NumberChanger<int>(AddNum);
            NumberChanger<int> nc2 = new NumberChanger<int>(MultNum);
            nc1(25);
            Console.WriteLine("Value of num: {0}", getNum());
            nc2(5);
            Console.WriteLine("Value of num: {0}", getNum());
            Console.ReadKey();
        }
    }
}
