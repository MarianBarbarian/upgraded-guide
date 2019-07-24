using System;

namespace Project_Day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program(); // run myself
        }

        public Program()
        {
            Console.WriteLine("Hello, I'm the constructor");

            SayHello(); //execute function
            TypeTests();
            printHellos(9);

            var sumValue = Sum(21, 21);
            System.Console.WriteLine("Sum Result" + sumValue);

            string res = myFavColor(true);
            Console.WriteLine(res);

            var divValue = Divide(45, 5);
            System.Console.WriteLine("Division Value " + divValue);

            TestArrays();

            HomeWork();
        }

        void TestArrays()
        {
            int[] numbers = new int[9]; //declare array
            numbers[0] = 1; // you store values in index
            numbers[1] = 89;
            numbers[2] = 45;
            numbers[3] = 1;


            // read store values
            int theVal = numbers[2]; //output

            for (int i = 0; i < numbers.Length; i++)
            {
                int theNumber = numbers[i];
                Console.WriteLine("from array: " + theNumber);
            }

        }

        void HomeWork()
        {

            int[] grades = new int[] { 2, 4, 2, 5, 1, 67, 45, 234, 56, 67, 3, 2134, 76, 98, 45, 123, 345, 5678 };
            //int[] grades = generateRandomArray();
            int greatest = 0;
            int smallest = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(grades[i]);
                
                if (grades[i] > grades[0])
                {
                    greatest = grades[i];
                }
                else
                {
                    smallest = grades[i];
                }
            }

            Console.WriteLine("Greatest number is " + greatest);
            Console.WriteLine("Smallest number is " + smallest);


            /*
            Homework (lab1):
            -find the lowest value
            -find the greatest value


            + how many are even
             */

        }

        int[] generateRandomArray()
        { //for otherArray
            int[] list = new int[95];
            for (int i = 0; i < 95; i++)
            {
                list[i] = new Random().Next(1000);
            }

            return list;
        }

        int SayHello()
        {
            Console.WriteLine("Hello I'm a method");
            int a = 98;
            if (a == 91)
            {
                return 1;
            }

            else
            {
                Console.WriteLine("its not 91");
                return 2;
            }
        }

        void TypeTests()
        {
            // var, let, boolean
            string name = "Marian"; //double quotes for strings
            int age = 0; // cannot bet decimal
            double phi = 3.1415927;
            bool isItTrue = false;

            char letter = 'c'; //single quotes
            float weight = 0f; //store decimal values
            decimal price = 123.456m;
        }

        void printHellos(int howMany)
        {
            //for 
            for (int i = 0; i < howMany; i++)
            {
                System.Console.WriteLine("Hello");

            }
        }

        string myFavColor(bool thing)
        {
            if (thing == false)
            {
                return "red";
            }

            else
            {
                return "blue";
            }
        }

        int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        void test()
        {
            int r = new Random().Next(50);
        }

        int Divide(int num1, int num2)
        {
            if (num2 == 0)
            {
                System.Console.WriteLine("Tried to divide by 0");
                return 0;
            }

            return num1 / num2;
        }

    }

}