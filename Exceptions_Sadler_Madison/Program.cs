// See https://aka.ms/new-console-template for more information
// System.Net.Security namespace needed to use Console class
using System.Net.Security;

// Declares a float called myFloat and assigns to value 65.45f
float myFloat = 65.45f;
// Declares a float called myOtherFloat and assigns to value 0.0f
float myOtherFloat = 0.0f;
// Declares a float called myResult and assigns to value 0f
float myResult = 0f;

// Creates a new Random object called rand
Random rand = new Random();
// Initializes an integer called myInt with a random range from 2 to 30
int myInt = rand.Next(2, 30);

// Creates a try statement that assigns myResult to a Divide method that passes through variables myFloat and myOtherFloat
try
{
    myResult = Divide(myFloat, myOtherFloat);
}
// Catches any exceptions and prints to the console an error message and asks the user to enter a number other than zero
catch (Exception e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine("Please enter a number other than zero.");

    // Creates a try statement that assigns myOtherFloat to (float)Convert.ToDouble(Console.Readline())
    // Assigns myResult to a Divide method that passes through variables myFloat and myOtherFloat
    try
    {
        myOtherFloat = (float)Convert.ToDouble(Console.ReadLine());
        myResult = Divide(myFloat, myOtherFloat);
    }
    // Catches any exceptions and prints to the console an error message
    catch (Exception e2)
    {
        Console.WriteLine(e2.Message);
    }
}
// Creates a finally block that prints to the console that calculations are completed with the result
finally 
{
    Console.WriteLine($"Calculations completed, with result of {myResult}!");
}

// Creates a try statement that calls CheckAge and passes through variable myInt
try
{
    CheckAge(myInt);
}
// Creates a catch block that prints to the console that the user is not old enough
catch
{
    Console.WriteLine("You are not old enough!");
}

// Creates a static float method called Divide that takes float parameters a and b
static float Divide(float a, float b)
{
    // Creates an if else statement that sets b equal to 0 and throws a DivideByZeroException, otherwise returns a divided by b
    if (b == 0)
    {
        throw new DivideByZeroException();
    }
    else
    {
        return a / b;
    }
}

// Creates a static void method called CheckAge that takes integer parameter age
static void CheckAge(int age)
{
    // Creates an if else statement that states if age is greater than or equal to 17, it prints to the console the age you inputted as your age and that you can play mature games
    // Else it throws an ArgumentException
    if (age >= 17)
    {
        Console.WriteLine($"You are {age}, you can play mature games!");
    }
    else
    {
        throw new ArgumentException();
    }
}
