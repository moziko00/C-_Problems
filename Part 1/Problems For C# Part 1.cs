using System;
using System.Threading;

namespace Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem 1: Write a program that allows the user to enter a number then print it.

            //Console.WriteLine("Please Enter The Number U want To Print It ");
            //int number=int.Parse(Console.ReadLine());
            //Console.WriteLine($"The Number U want To Print It is {number}");

            #endregion

            #region Problem 2 : Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            //Console.WriteLine("Please Enter Any Number u Want");
            //int number =int.Parse(Console.ReadLine());
            //if ((number % 3==0) ||(number%4==0)) 
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No");
            #endregion

            #region Problem 3: Write a program that allows the user to insert 2 integers then print the max.
            //Console.WriteLine("Please Enter Any Two Number");
            //int number1=int.Parse(Console.ReadLine());
            //int number2=int.Parse(Console.ReadLine());

            ////int MaxNumber = Math.Max(number1, number2);
            ////Console.WriteLine($"The Max Number is {MaxNumber}");
            //// Another Way
            //if ( number1 > number2 )
            //    Console.WriteLine($"The Max Number is {number1}");
            //else if( number1 < number2 )
            //    Console.WriteLine($"The Max Number is {number2}");
            #endregion

            #region Problem 4: Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //Console.WriteLine("Please Enter Any Number U Want");
            //int number=int.Parse(Console.ReadLine());
            //if (number > 0)
            //    Console.WriteLine("Positive");
            //else if (number < 0)
            //    Console.WriteLine("Negative");
            #endregion

            #region Problem 5: Write a program that takes 3 integers from the user then prints the max element and the min element
            //Console.WriteLine("Please Enter Three Number To Get The Maxmum Number");
            //int number1=int.Parse(Console.ReadLine());
            //int number2=int.Parse(Console.ReadLine());
            //int number3=int.Parse(Console.ReadLine());

            //Console.WriteLine($"The Maxmum Number is {Math.Max(number1, Math.Max(number2, number3))}");
            //Console.WriteLine($"The Minmum Number is {Math.Min(number1,Math.Min(number2,number3))}");
            #endregion

            #region Problem 6: Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //Console.WriteLine("Please Enter Any Number U Want");
            //int number=int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //    Console.WriteLine("This Number is Even");
            //else if (number % 2 == 1)
            //    Console.WriteLine("This Number Is Odd");
            #endregion

            #region Problem 7:Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant)  
            //Console.WriteLine("Please Enter Any Character");
            //char X=char.Parse(Console.ReadLine());
            //if (X == 'a' || X == 'e' || X == 'i' || X == 'o' || X == 'u' || X == 'A' || X == 'E' || X == 'I' || X == 'O' || X == 'U')
            //    Console.WriteLine("This is Vowel");
            //else
            //    Console.WriteLine("Consonant");
            #endregion

            #region Problem 8: Write a program to enter marks of five subjects and calculate total, average and percentage.
            //double num,sum = 0;
            //double Average, Percentage;
            //int count = 0;
            //Console.WriteLine("Please Enter Your Five Subject ");
            //while(count<5)
            //{
            //    Console.WriteLine($"Please Enter Subject{count+1} : ");
            //    num=double.Parse(Console.ReadLine());
            //    sum += num;
            //    count++;
            //}
            //Console.WriteLine($"The Total Is: {sum}");
            //Average = sum / 5;
            //Console.WriteLine($"The Average is: {Average}");
            //Percentage = (sum * 100) / 500;
            //Console.WriteLine($"The Percentage is: {Percentage}%");

            #endregion

            #region Problem 9: Write a program to input the month number and print the number of days in that month.
            //Console.WriteLine("Please Enter Any Month");
            //int month=int.Parse(Console.ReadLine());
            //if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            //    Console.WriteLine("Days in Month is 31");

            //else if (month == 4 || month == 6 || month == 9 || month == 11)
            //    Console.WriteLine("Days in Month is 30");

            //else if (month == 2)
            //    Console.WriteLine("Days in Month 28");
            //else
            //    Console.WriteLine("In Valid Month");
            #endregion

            #region Problem 10: Write a program to input marks of five subjects Physics, Chemistry, Biology, Mathematics and Computer, And Calculate percentage and grade.
            //double sum = 0, num, percentage;
            //int count = 0;
            //while(count<5)
            //{
            //    Console.WriteLine($"Please Enter Subject {count+1}");
            //    num=double.Parse(Console.ReadLine());
            //    sum += num;
            //    count++;
            //}
            //percentage = (sum * 100) / 500;
            //if (percentage>=90)
            //    Console.WriteLine($"The Gard is A and The Percentage is {percentage}");
            //else if (percentage >= 80)
            //    Console.WriteLine($"The Gard is B and The Percentage is {percentage}");
            //else if (percentage >= 70)
            //        Console.WriteLine($"The Gard is C and The Percentage is {percentage}");

            //else if (percentage >= 60)
            //    Console.WriteLine($"The Gard is D and The Percentage is {percentage}");

            //else if (percentage >=40)
            //    Console.WriteLine($"The Gard is A and The Percentage is {percentage}");
            //else if (percentage <40)
            //    Console.WriteLine($"The Gard is F and The Percentage is {percentage}");
            #endregion

            #region Problem 10: Write a program to check whether a number is positive or negative or zero using Switch.
            //Console.WriteLine("Please Enter Any Number U Want");
            //int number = int.Parse(Console.ReadLine());
            //switch (number)
            //{
            //    case > 0:
            //        Console.WriteLine("The Number is Positive");
            //        break;

            //    case < 0:
            //        Console.WriteLine("The Number is Negative");
            //        break;
            //    case  0:
            //            Console.WriteLine("The Number Is Zero");
            //        break;
            //}
            #endregion

            #region Problem 11: Write a program to create a Simple Calculator using Switch
            //double number1, number2, result;
            //string symbol;

            //Console.WriteLine("Please Enter the First Number");
            //number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please Enter The Second Numebr");
            //number2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please Enter The Symbol");
            //symbol = Console.ReadLine();
            //switch (symbol)
            //{
            //    case "+":
            //        result = number1 + number2;
            //        Console.WriteLine($"The Result is {result}");
            //        break;
            //    case "-":
            //        result = number1 - number2;
            //        Console.WriteLine($"The Result is {result}");
            //        break;
            //    case "*":
            //        result = number1 * number2;
            //        Console.WriteLine($"The Result is {result}");
            //        break;
            //    case "/":
            //        result = number1 / number2;
            //        Console.WriteLine($"The Result is {result}");
            //        break;
            //    default:
            //        Console.WriteLine("Wrong Input");
            //        break;
            //}


            #endregion


        }
    }
}
