namespace OperatorsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operators
            //Assignment Operator =
            //int x = 5;
            //int y = 10;
            int num1 = 10;
            int num2 = 5;

            num1 += num2; //equivalent to num1 = num1 + num2
            num1 -= num2; //equivalent to num1 = num1 - num2
            num1 *= num2; //equivalent to num1 = num1 * num2
            num1 /= num2; //equivalent to num1 = num1 / num2

            //Arithmetic Operators
            //int additionResult = x + y;
            //int subtractionResult = x - y;
            //int multiplicationResult = x * y;
            //int divisionResult = x / y;
            //int modulusResult = x % y; // remainder after division

            //check to see if a number is even or odd - (bool evenOrOdd = number % 2 == 0;)

            //Unary Operators
            int x = 3;
            int y = ++x; //pre increment
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine();

            int a = 3;
            int b = a++; //post increment
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine();

            int c = 5;
            Console.WriteLine(--c); //pre decrement
            int d = 4;
            Console.WriteLine(d--);//post decrement
            Console.WriteLine(d);

            //Relational Operators

            int e = 5;
            int f = 3;

            bool isEqual = e == f; //Checks if e is equal to f (false)
            bool notEqual = e != f; //Checks if e is NOT equal to f (true)
            bool greaterThan = e > f; //Checks if e is greater than f (true)
            bool lessThan = e < f; //Checks if e is less than f (false)
            bool greaterThanOrEqual = e >= f; //Checks if e is greater than or equal to f
            bool lessThanOrEqual = e <= f; //Checks if e is less than or equal to f


            //Logical Operators

            bool result1 = a == 5 && b > 5; //Checks if both conditions are true
            bool result2 = b < 10 || c > 20; //Checks if either condition is true

            //Null Coalescing Operator

            int? possiblyNullValue = null;
            int notNullNum = possiblyNullValue ?? 500;
            Console.WriteLine(notNullNum);

        }
    }
}