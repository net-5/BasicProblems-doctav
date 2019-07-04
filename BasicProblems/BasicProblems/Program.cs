﻿using System;
using System.Text;

namespace BasicProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Here are some basic solved problems...\n");
            SumOfThreeFromConsole();
            GreastestOfFiveNumbers();
            CirclePerimeterAndArea();
            DivisibleByFive();
            GreaterOfTwo();
            FiveIntegersAndSum();
            WriteNNumbers();
            PrintNumbersNotDivisible37();
            SmallestAndLargest5();
            TriangleStars();
            DecimalToBinary();
            RandomNumbers();
            FizzBuzz();
            CompanyManagerData();
        }

        //1. Write a program that reads from the console three numbers of type int and prints their sum.
        static void SumOfThreeFromConsole()
        {
            Console.WriteLine("1. Write a program that reads from the console three numbers of type int and prints their sum.");
            Console.WriteLine("Input 1st number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input 2nd number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Input 3rd number");
            int c = int.Parse(Console.ReadLine());

            int sum = a + b + c;
            Console.WriteLine($"The sume {a}+{b}+{c}={sum}.\n");
        }

        //2. Write a program that reads five numbers from the console and prints the greatest of them.
        static void GreastestOfFiveNumbers()
        {
            Console.WriteLine("2. Write a program that reads five numbers from the console and prints the greatest of them.");
            decimal currentNumber, max;
            Console.WriteLine("Input the number no. 1");
            currentNumber = decimal.Parse(Console.ReadLine());
            max = currentNumber;
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Input the number no." + (i + 1));
                currentNumber = decimal.Parse(Console.ReadLine());
                if (currentNumber > max)
                    max = currentNumber;
            }
            Console.WriteLine($"The greatest number is {max}\n");
        }

        //3. Write a program that reads from the console the radius "r" of a circle and prints its perimeter and area.
        static void CirclePerimeterAndArea()
        {
            Console.WriteLine("3. Write a program that reads from the console the radius \"r\" of a circle and prints its perimeter and area.");
            Console.WriteLine("Input the Radius");
            float radius = float.Parse(Console.ReadLine());
            double perimeter, area;
            perimeter = 2 * Math.PI * radius;
            area = Math.PI * radius * radius;
            Console.WriteLine($"The perimeter = {perimeter}. The area = {area}\n");
        }

        //4. Write a program that reads from the console two integer numbers (int) and prints how many numbers between them exist that are divisible with 5. such that the remainder of their division by 5 is 0.
        static void DivisibleByFive()
        {
            Console.WriteLine("4. Write a program that reads from the console two integer numbers  and prints how many numbers between them exist that are divisible with 5. such that the remainder of their division by 5 is 0.");
            int a, b;
            Console.WriteLine("Input the first number");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the second number");
            b = int.Parse(Console.ReadLine());

            if (a > b)  //check if a<b. Otherwise, swap them.
            {
                int temp;
                temp = a;
                a = b;
                b = temp;
            }

            int numberOfDivisibleWithFive = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0)
                    numberOfDivisibleWithFive++;
            }
            Console.WriteLine($"Between {a} and {b} the are {numberOfDivisibleWithFive} numbers divisible with 5.\n");
        }

        //5. Write a program that reads two numbers from the console and prints the greater of them. Solve the problem without using conditional statements and with conditional statements.
        static void GreaterOfTwo()
        {
            Console.WriteLine("5. Write a program that reads two numbers from the console and prints the greater of them. Solve the problem without using conditional statements and with conditional statements.");
            double a, b;
            Console.WriteLine("Input the first number");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Input the second number");
            b = double.Parse(Console.ReadLine());
            if (a > b)
                Console.WriteLine($"The greater is {a}");
            else
                Console.WriteLine($"The greater is {b}");
            //without conditional statement
            double max = a > b ? a : b;
            Console.WriteLine($"The greater is {max}\n");
        }

        //6. Write a program that reads five integer numbers and prints their sum. If an invalid number is entered the program should prompt the user to enter another number(only once)
        static void FiveIntegersAndSum()
        {
            Console.WriteLine("6. Write a program that reads five integer numbers and prints their sum. If an invalid number is entered the program should prompt the user to enter another number(only once)");
            int canRead = 0, i = 1, sum = 0;
            while (i <= 5 && canRead < 2)
            {
                Console.WriteLine($"Input the number with the index {i}");
                if (int.TryParse(Console.ReadLine(), out int currentNumber))
                {
                    sum = sum + currentNumber;
                }
                else
                {
                    //one more chance
                    canRead++;
                    i--;
                }
                //read the next number
                i++;
            }

            //check if all the numbers are ok
            if (canRead < 2)
            {
                Console.WriteLine($"The sum is {sum}\n");
            }
            else
            {
                Console.WriteLine("Too many tries...Sorry...\n");
            }

        }

        //7. Write a program that prints on the console the numbers from 1 to N. The number N should be read from the standard input.
        static void WriteNNumbers()
        {
            Console.WriteLine("7. Write a program that prints on the console the numbers from 1 to N. The number N should be read from the standard input.");
            Console.WriteLine("Input N");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }

        //8. Write a program that prints on the console the numbers from 1 to N, which are not divisible by 3 and 7 simultaneously. The number N should be read from the standard input.
        static void PrintNumbersNotDivisible37()
        {
            Console.WriteLine("8. Write a program that prints on the console the numbers from 1 to N, which are not divisible by 3 and 7 simultaneously. The number N should be read from the standard input.");
            Console.WriteLine("Input N");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The numbers are:");
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                    Console.WriteLine(i);
            }
        }

        //9. Write a program that reads from the console a series of 5 integers and prints the smallest and largest of them.
        static void SmallestAndLargest5()
        {
            int min, max, currentNumber;
            Console.WriteLine("9. Write a program that reads from the console a series of 5 integers and prints the smallest and largest of them.");
            Console.WriteLine("Input 1st number");
            currentNumber = int.Parse(Console.ReadLine());
            min = currentNumber;
            max = currentNumber;
            for (int i = 2; i <= 5; i++)
            {
                Console.WriteLine($"Input the {i}rd number");
                currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber > max)
                    max = currentNumber;

                if (currentNumber < min)
                    min = currentNumber;
            }
            Console.WriteLine($"Max={max}, Min={min}");
        }

        //10. Write program that outputs a triangle made of stars with variable size, depending on an input parameter. Look at the examples to get an idea. The input comes as a string number, which needs to be parsed to a number. The output is a series of lines printed on the console, forming a triangle of variable size.
        static void TriangleStars()
        {
            Console.WriteLine("10. Write program that outputs a triangle made of stars with variable size, depending on an input parameter. Look at the examples to get an idea. The input comes as a string number, which needs to be parsed to a number. The output is a series of lines printed on the console, forming a triangle of variable size.");
            Console.WriteLine("Input N (size of triangle)");
            int n = int.Parse(Console.ReadLine());

            //the first half of the triangle
            for (int i = 1; i <= n; i++)
            {
                //build the current line of stars (from 1 to i)
                StringBuilder sb = new StringBuilder();
                for (int j = 1; j <= i; j++)
                {
                    sb.Append("*");   //add a star to the current line
                }
                Console.WriteLine(sb.ToString());
            }

            //the second half of the triangle
            for (int i = n - 1; i >= 1; i--)
            {
                //build the current line of stars (from 1 to i)
                StringBuilder sb = new StringBuilder();
                for (int j = 1; j <= i; j++)
                {
                    sb.Append("*");  //add a star to the current line
                }
                Console.WriteLine(sb.ToString());
            }
        }

        //11. Write a program that converts a given number from decimal to binary notation (numeral system).
        static void DecimalToBinary()
        {
            Console.WriteLine("11. Write a program that converts a given number from decimal to binary notation (numeral system).");
            Console.WriteLine("Input N (decimal number)");
            int n = int.Parse(Console.ReadLine());

            string resultInBinary = "";

            while (n > 0)
            {
                int rest = n % 2;
                resultInBinary = rest + resultInBinary;
                n = n / 2;
            }
            Console.WriteLine($"The binary value of {n} is {resultInBinary}");
        }

        //12. Write a program that by a given integer N prints the numbers from 1 to N in random order
        static void RandomNumbers()
        {
            Console.WriteLine("12. Write a program that by a given integer N prints the numbers from 1 to N in random order");

            Console.WriteLine("Input N");
            int n;
            n = int.Parse(Console.ReadLine());
            int[] values = new int[n + 1];

            int printedNumbers = 0;
            for (int i = 1; i <= n; i++)
            {
                values[i] = i + 1;
            }

            Console.WriteLine("The numbers are:");
            while (printedNumbers < n)
            {
                Random rd = new Random();
                int currentNumber = rd.Next(1, n + 1);  //get a new random number
                //check if the currentNumber wasn't already printed
                if (values[currentNumber] != -1)
                {
                    Console.WriteLine(currentNumber);
                    values[currentNumber] = -1;
                    printedNumbers++; //one more number was just printed
                }
            }
            Console.WriteLine("That's all, folks...");
        }

        //13. A program which iterates the integers from 1 to 50 For multiples of three print "Fizz" instead of the number and for the multiples of five print "Buzz". For numbers which are multiples of both three and five print "FizzBuzz".
        static void FizzBuzz()
        {
            Console.WriteLine("13. A program which iterates the integers from 1 to 50 For multiples of three print \"Fizz\" instead of the number and for the multiples of five print \"Buzz\". For numbers which are multiples of both three and five print \"FizzBuzz\".");
            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                if (i % 3 == 0 && i % 5 != 0)
                    Console.WriteLine("Fizz");
                if (i % 5 == 0 && i % 3 != 0)
                    Console.WriteLine("Buzz");
                if (i % 5 != 0 && i % 3 != 0)
                    Console.WriteLine(i);
            }
        }

        //14. A given company has name, address, phone number, fax number, web site and manager. The manager has name, surname and phone number. Write a program that reads information about the company and its manager and then prints it on the console.
        static void CompanyManagerData()
        {
            Console.WriteLine("14. A given company has name, address, phone number, fax number, web site and manager. The manager has name, surname and phone number. Write a program that reads information about the company and its manager and then prints it on the console.");
            string cName, cAddress, cPhone, cFax, cWeb, cManager;
            string mName, mSurname, mPhone;

            Console.WriteLine("Input the data about the company:");

            Console.WriteLine("Company name");
            cName = Console.ReadLine();
            Console.WriteLine("Company address");
            cAddress = Console.ReadLine();
            Console.WriteLine("Company phone");
            cPhone = Console.ReadLine();
            Console.WriteLine("Company fax");
            cFax = Console.ReadLine();
            Console.WriteLine("Company web site");
            cWeb = Console.ReadLine();
            Console.WriteLine("Company manager");
            cManager = Console.ReadLine();

            Console.WriteLine("\nInput the data about the manager:");
            Console.WriteLine("Manager name");
            mName = Console.ReadLine();
            Console.WriteLine("Manager surname");
            mSurname = Console.ReadLine();
            Console.WriteLine("Manager phone");
            mPhone = Console.ReadLine();

            Console.WriteLine($"The company {cName} is located at {cAddress}. It has the phone fax numbers {cPhone} and {cFax}. " +
                $"The website is {cWeb} and the manager is {cManager}");
            Console.WriteLine($"The manger is {mName} {mSurname} and can be called at phone {mPhone}");
        }
    }
}
