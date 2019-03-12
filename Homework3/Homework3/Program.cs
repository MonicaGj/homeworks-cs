using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {

            //    Task 1.
            //Write a program that will print out all numbers from the range 1 - N
            //(N is input from keyboard, N > 2) that divide with 3.
            //Console.WriteLine("Vnesete broj pogolem od 2!");
            //string num = Console.ReadLine();
            //int n = int.Parse(num);

            //for(int i = 1; i<=n; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.Write($"{i}" + " ");
            //    }

            //}

            //Console.ReadLine();

            //Task 2.
            //Write a program that will print out all numbers in the range 1 - 
            //N(N is input from keyboard, N > 5) that divide 2 and 3.

            //Console.WriteLine("Vnesete broj pogolem od 5!");
            //string num1 = Console.ReadLine();
            //int n1 = int.Parse(num1);

            //if(n1 > 5)
            //{
            //    for (int i = 1; i <= n1; i++)
            //    {
            //        if (i % 2 == 0 && i % 3 == 0)
            //        {
            //            Console.Write($"{i}" + " ");
            //        }

            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Brojot treba da e pogolem od 5!");
            //}


            //Console.ReadLine();


            //Task 3.
            //Write a program, which will be calculating the 
            //product of the digits of an input number.


            //Console.WriteLine("Vnesete broj!");
            //string number1 = Console.ReadLine();
            //int numb1 = int.Parse(number1);

            //int[] digits = new int[0];
            //while (numb1 > 0)
            //{
            //    int digit = numb1 % 10;
            //    numb1 /= 10;
            //    Array.Resize(ref digits, digits.Length + 1);
            //    digits[digits.Length - 1] = digit;

            //}

            //int product = 1;
            //foreach(int n in digits)
            //{
            //     product *= n;
            //}

            //Console.WriteLine($"Proizvodot e {product}");
            //Console.ReadLine();




            //Task 4.
            //Write a program that will find out the sum of all even
            //numbers in the range 1 - N(N is input from keyboard).

            //Console.WriteLine("Vnesi broj!");
            //int n = int.Parse(Console.ReadLine());

            //int sum = 0;
            //for(int i=1; i<=n; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum += i;
            //    }
            //}

            //Console.WriteLine($"Sumata e {sum}");
            //Console.ReadLine();


            //Task 5.
            //Write a program that will find out the 
            //sum of all odd numbers in the range 1 - N(N is input from keyboard).

            //Console.WriteLine("Vnesi broj!");
            //int n = int.Parse(Console.ReadLine());

            //int sum = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        sum += i;
            //    }
            //}

            //Console.WriteLine($"Sumata e {sum}");
            //Console.ReadLine();


            //Task 6.
            //Write a program that will find out the sum of all 
            //numbers that divide 5 in the range 1 - N(N is input from keyboard)

            //Console.WriteLine("Vnesi broj!");
            //int n = int.Parse(Console.ReadLine());

            //int sum = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        sum += i;
            //    }
            //}

            //Console.WriteLine($"Sumata e {sum}");
            //Console.ReadLine();


            //Task 7.
            //Write a program that will reverse the array {“a”,”b”,”c”,”d”}
            //so that the output is {“d”,“c”,“b”,“a”}. Hint: use Array.Reverse().

            //string[] letters = new string[] { "a", "b", "c", "d" };
            //Array.Reverse(letters);

            //foreach(string n in letters)
            //{

            //    Console.Write(n);
            //}

            //Console.ReadLine();


            //Task 8.
            //Write a program that will read two arrays Niza1 and Niza2.Then the program has to make a 
            //comparison of the arrays and determine whether they are equal or not.

            //int[] niza1 = new int[] { 1, 2, 3, 4 };
            //int[] niza2 = new int[] { 1, 2, 3, 4 };

            //if((niza1.SequenceEqual(niza2)) == true)
            //{
            //    Console.WriteLine("Nizite se isti");
            //}
            //else
            //{
            //    Console.WriteLine("Nizite se razlichni");
            //}

            //Console.ReadLine();


            //Task 11.
            //Write a program that will print out all two-digit numbers,
            //which have the first digit greater than the second digit.

            //int[] digits = new int[0];

            //for (int i=10; i<100; i++)
            //{
            //    int digit2 = i % 10;
            //    int digit1 =i/ 10;
            //    if (digit1 > digit2)
            //    {
            //        Array.Resize(ref digits, digits.Length + 1);
            //        digits[digits.Length - 1] = i;
            //    }

            //}

            //foreach(int n in digits)
            //{
            //    Console.Write(n + " ");
            //}
            //Console.ReadLine();



            //Task 12: 
            //Write a short program that prints each number from 1 to 100 on a new line.
            //For each number that is divided by 3 print “Fizz” instead of the number.
            //For each number that is divided by 5 print “Buzz” instead of the number.
            //For each number that is divided by 3 and 5  print “FizzBuzz” instead of the number.


            for(int i=1; i<=100; i++)
            {
                
                if(i%3 == 0 && i % 5 ==0)
                {
                 
                    Console.WriteLine($"{i} FizzBuzz");
                }
                else if(i%5 == 0)
                {
                    Console.WriteLine($"{i} Buzz");
                }
                else if (i % 3 == 0 )
                {
                    Console.WriteLine($"{i} Fizz");
                }
                else
                {
                    Console.WriteLine($"{i}");
                }
                
            }

            Console.ReadLine();

        }
    }
}
