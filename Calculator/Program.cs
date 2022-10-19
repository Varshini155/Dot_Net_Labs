using System;

class Program
{
    public delegate void calculator(int num1 , int num2);
    static void Main()
    {
        calculator Calculator = new calculator((num1 ,num2) =>{ Console.WriteLine("Addition of 30 and 6 is " + (num1 + num2)); });
        
        Calculator += ((num1, num2) => { Console.WriteLine("Subtraction of 30 and 6 is " + (num1 - num2)); });
        Calculator += ((num1, num2) => { Console.WriteLine("Multiplication of 30 and 6 is " + (num1 * num2)); });
        Calculator += ((num1, num2) => { Console.WriteLine("Divide of 30 and 6 is " + (num1 / num2)); });

        Calculator(30, 6);

    }

    private static void Divide(int num1, int num2)
    {
       //Console.WriteLine("Division of 30 and 6 is "+ (num1 / num2));
    }

    private static void Multiply(int num1, int num2)
    {
       // Console.WriteLine("multiplication of 30 and 6 is "+(num1 * num2));
    }

    private static void Subtract(int num1, int num2)
    {
       // Console.WriteLine("substraction of 30 and 6 is " +( num1 - num2));
    }

    private static void Add(int num1, int num2)
    {
       // Console.WriteLine("Addition of 30 and 6 is " + (num1 + num2));
    }
}
