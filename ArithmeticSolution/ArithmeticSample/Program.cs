using System;

namespace ArithmeticSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //The special charcter \n adds an extra blank line
            //It is called the next line character
            Console.WriteLine("Arithmetic Samples\n");

            //Declare a variable of data type double
            //syntax; datatype variablename assignment operator literal numeric value
            //Data type: double || Variable name: Total || Operator: = || Literal: 0.0
            double Total = 0.0;
            double Cost = 15.23;
            double Tax = 0.81;

            //arithmetic assignment operation
            //syntax; recieving variable assignment operator binary arithmetic expression
            //Variable name: Total || Operator: = || Literal: Cost + Tax
            //acttion: the expression will be executed and the results will be placed into the recieving variable
            Total = Cost + Tax;

            Console.WriteLine($"The result of {Cost} + {Tax} is {Total}");

            //An alternate way of outputting your variables will be to use string concatenation
            //String concatenation uses the operator +
            Console.WriteLine("The result of " + Cost + " + " + Tax + " is " + Total);

            //You can aslos use placeholders, they start at 0 and increment by 1
            //Placeholder values are in a list after the string so order is important
            Console.WriteLine("The result of {0} + {1} is {2}",Cost,Tax,Total);

        }

    }
}
