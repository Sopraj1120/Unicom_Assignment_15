using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //hello();
            //namegreed();
            // sum();
            //celsius();
            //even();
            //add();
            //sub();
            //mul();
            //divide();
            //Console.WriteLine(prime());
            //int n = Console.ReadLine();
            //Console.WriteLine("Enter value");
            //int n = int.Parse(Console.ReadLine());

            //Console.WriteLine(factorial(n));
            //swit();
            //Vowels();
            //Console.WriteLine(countVowels("Sopraj"));
            //multy(8);
            //Console.WriteLine(countLetters("hello mister",'h'));
            //Console.WriteLine(gcd(12, 32));
            guessNumber();



            Console.ReadLine();
        }
        static void hello()
        {
            Console.WriteLine("Hello World");

        }

        static void namegreed()
        {
            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome " + name);
        }
        static void sum()
        {
            Console.WriteLine("Enter the First Number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Scond Number");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine($"sum = " + sum);
        }
        static void celsius()
        {
            Console.WriteLine("Enter Celsius Value");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = ((celsius * 5 / 9) + 32);
            Console.WriteLine($"Fahrenheit = " + fahrenheit);
        }
        static void even()
        {
            Console.WriteLine("enter the Value");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
        }
        static void add()
        {
            Console.WriteLine("enter the first value");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the scond value");
            int num2 = int.Parse(Console.ReadLine());
            int add = num1 + num2;
            Console.WriteLine(add);
        }
        static void sub()
        {
            Console.WriteLine("enter the first value");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the scond value");
            int num2 = int.Parse(Console.ReadLine());
            int sub = num1 - num2;
            Console.WriteLine(sub);
        }
        static void mul()
        {
            Console.WriteLine("enter the first value");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the scond value");
            int num2 = int.Parse(Console.ReadLine());
            int mul = num1 * num2;
            Console.WriteLine(mul);
        }
        static void divide()
        {
            Console.WriteLine("enter the first value");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the scond value");
            double num2 = double.Parse(Console.ReadLine());
            double divide = num1 / num2;
            Console.WriteLine(divide);
        }
        static bool prime()
        {
            Console.WriteLine("Enter the Integer Value");
            int num = int.Parse(Console.ReadLine());
            if (num <= 1)
            {
                return false;

            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;

                }

            }
            return true;


        }
        static int factorial(int n)
        {

            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * factorial(n - 1);
            }

        }
        static void swit()
        {

            Console.WriteLine("enter the opperatores");
            Char opperatores = Char.Parse(Console.ReadLine());

            switch (opperatores)
            {
                case '+':
                    add();
                    break;

                case '-':
                    sub();
                    break;

                case '*':
                    mul();
                    break;
                case '/':
                    divide();
                    break;
                default:
                    Console.WriteLine("Invalid Opparation");
                    break;
            }

        }
        static int countVowels(string input)
        {
            int count = 0;
            string vowels = " aeiouAEIOU";

            foreach (char c in input)
            {
                if (vowels.Contains(c))
                {
                    count++;
                }
            }
            return count;


        }
        static void multy(int number)
        {
            for (int i = 1; i <= 15; i++)
            {
                int table = number * i;
                Console.WriteLine($"{number}*{i}= {table} ");
            }
        }
        static int countLetters(string input, char character)
        {
            int count = 0;


            foreach (char c in input)
            {
                if (c == character)
                {
                    count++;
                }
            }
            return count;

        }

        static int gcd(int num1, int num2)
        {
            while (num2 != 0)
            {
                int tem = num2;
                num2 = num1%num2;
                num1 = tem;
            }
            return num1;
        }

       static void guessNumber()
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1, 100);
            bool guess = true;
            while (guess)
            {
                Console.WriteLine("please guess Your Number");
                int number= int.Parse(Console.ReadLine());
                if(randomNumber == number)
                {
                    Console.WriteLine("You Win");
                    guess = false;
                    return;

                }
                if(randomNumber > number)
                {
                    Console.WriteLine("Your Number is too low");
                }
                else
                {
                    Console.WriteLine("Your Number is too Heigh");
                }

            }
        }
    }
}
