using System;

namespace Question_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // -------  Question 1 ------------------------------------
            //Console.BackgroundColor = ConsoleColor.Red;
            //Console.WriteLine("Hello to my C# World!");
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("Hope wa have greate time together");
            //Console.Read();

            // -------  Question 2 ------------------------------------
            //double side;
            //double area;
            //Console.Write("Enter side = ");
            //string value = Console.ReadLine();
            //side = double.Parse(value);
            //area = Math.Pow(side, 3);
            //Console.WriteLine("Area of cube with the side {0} is {1}", side, area);
            //Console.Read();

            // -------  Question 3 ------------------------------------
            //Console.WriteLine("Enter number 1: ");
            //string number1Input = Console.ReadLine();
            //int number1 = int.Parse(number1Input);
            //Console.WriteLine("Enter number 2: ");
            //string number2Input = Console.ReadLine();
            //int number2 = int.Parse(number2Input);
            //Console.WriteLine("Enter operation: ");
            //string opt = Console.ReadLine();
            //double result;
            //result = Calculate(number1, number2, opt);
            //Console.WriteLine("Calculate: {0} {1} {2} = {3}", number1, opt, number2, result);

            // -------  Question 4 ------------------------------------
            //Console.Write("\n\nFunction: To display the n number Fibonacci series :\n");
            //Console.Write("--------------------------------------------------------\n");
            //Console.Write("Input number of Fibonacci Series : ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("The Fibonacci serires of " + n + " numbers is : ");
            //for (int i = 0; i < n; i++) {
            //    Console.Write(Fibo(i) + " ");
            //}
            //Console.WriteLine();

            // -------  Question 5 ------------------------------------
            //Console.WriteLine("Enter Type Of Day: ");
            //string typeDay = Console.ReadLine();
            //Console.WriteLine("Enter Age: ");
            //string ageInput = Console.ReadLine();
            //int age = int.Parse(ageInput);
            //if (typeDay == "Weekday" && age <= 18 && age >= 0)
            //{
            //    Console.WriteLine("Out put: 12$");
            //}
            //else if (typeDay == "Weekday" && age > 18 && age <= 64)
            //{
            //    Console.WriteLine("Out put: 18$");
            //}
            //else if (typeDay == "Weekday" && age > 64 && age <= 122) {
            //    Console.WriteLine("Out put: 12$");
            //}

            //// ------------------
            //else if (typeDay == "Weekend" && age <= 18 && age >= 0)
            //{
            //    Console.WriteLine("Out put: 15$");
            //}
            //else if (typeDay == "Weekend" && age > 18 && age <= 64)
            //{
            //    Console.WriteLine("Out put: 20$");
            //}
            //else if (typeDay == "Weekend" && age > 64 && age <= 122)
            //{
            //    Console.WriteLine("Out put: 15$");
            //}

            //// ------------------------
            //else if (typeDay == "Holiday" && age <= 18 && age >= 0)
            //{
            //    Console.WriteLine("Out put: 5$");
            //}
            //else if (typeDay == "Holiday" && age > 18 && age <= 64)
            //{
            //    Console.WriteLine("Out put: 12$");
            //}
            //else if (typeDay == "Holiday" && age > 64 && age <= 122)
            //{
            //    Console.WriteLine("Out put: 10$");
            //}


            // -------  Question 6 ------------------------------------
            //int hours = int.Parse(Console.ReadLine());
            //int min = int.Parse(Console.ReadLine());

            //min += 30;

            //if (min > 59) {
            //    hours ++;
            //    min -= 60;
            //}

            //if (hours > 23) {
            //    hours = 0;
            //}
            //Console.WriteLine("{0}: {1:d2}", hours, min);

            // -------  Question 7 ------------------------------------
            //Console.Write("Enter number: ");
            //int number = int.Parse(Console.ReadLine());
            //string month;
            //switch (number) {
            //    case 1: month = "January";
            //        break;
            //    case 2: month = "February";
            //        break;
            //    case 3:
            //        month = "March";
            //        break;
            //    case 4:
            //        month = "April";
            //        break;
            //    case 5:
            //        month = "May";
            //        break;
            //    case 6:
            //        month = "June";
            //        break;
            //    case 7:
            //        month = "July";
            //        break;
            //    case 8:
            //        month = "August";
            //        break;
            //    case 9:
            //        month = "September";
            //        break;
            //    case 10:
            //        month = "October";
            //        break;
            //    case 11:
            //        month = "November";
            //        break;
            //    case 12:
            //        month = "December";
            //        break;
            //    default:
            //        month = "Invalid !";
            //        break;
            //}
            //Console.WriteLine(month);

            // -------  Question 8 ------------------------------------
            Console.WriteLine("Enter Your Country: ");
            string country = Console.ReadLine();
            string language;
            if (country == "USA")
            {
                Console.WriteLine("Language: English");
            }
            else if (country == "Spanish")
            {
                Console.WriteLine("Language: Spain");
            }
            else {
                Console.WriteLine("Unknow !");
            }

        }

        //public static double Calculate(int n1, int n2, string opt) {
        //    double result = 0;
        //    switch (opt) {
        //        case "+":
        //            result = n1 + n2;
        //            break;
        //        case "-":
        //            result = n1 - n2;
        //            break;
        //        case "*":
        //            result = n1 * n2;
        //            break;
        //        case "/":
        //            try
        //            {
        //                result = n1 / n2;
        //            }
        //            catch (Exception c) {
        //                Console.WriteLine(c);

        //            }
        //            break;
        //        default:
        //            Console.WriteLine("Invalid");
        //            break;
        //    }
        //    return result;
        //}



        //public static int Fibo(int nno) {
        //    int num1 = 0;
        //    int num2 = 1;

        //    for (int i = 0; i < nno; i++)
        //    {
        //        int temp = num1; // 0

        //        num1 = num2; // 1
        //        num2 = temp + num2; // 1
        //    }
        //    return num1;
        //}
    }
}
