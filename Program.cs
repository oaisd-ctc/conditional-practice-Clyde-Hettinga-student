
public class Program
{
    public static void Main(string[] args)
    {
        FahrenheitToCelsius(-40); // Test FahrenheitToCelsius Function with a random value

        // Test your functions by calling them below:
        Console.WriteLine();
        CheckForPositiveNegativeZero(-1);
        CheckForPositiveNegativeZero(1);
        CheckForPositiveNegativeZero(0);
        
        Console.WriteLine();
        FindMinimum(1, 2, 3);
        FindMinimum(2, 1, 3);
        FindMinimum(3, 2, 1);
        
        Console.WriteLine();
        FindMaximum(1, 2, 3);
        FindMaximum(2, 1, 3);
        FindMaximum(3, 2, 1);
        
        Console.WriteLine();
        IsDivisibleBy5(5);
        IsDivisibleBy5(6);
        
        Console.WriteLine();
        CheckEvenOrOdd(2);
        CheckEvenOrOdd(3);
        
        Console.WriteLine();
        CheckVowelOrConsonant('e');
        CheckVowelOrConsonant('E');
        CheckVowelOrConsonant('s');
        CheckVowelOrConsonant('S');
        
        Console.WriteLine();
        DisplayDayOfWeek(0);
        DisplayDayOfWeek(3);
        DisplayDayOfWeek(6);

    }

    public static void FahrenheitToCelsius(double fahrenheit)
    {
        double celsiusDegree = (fahrenheit - 32) * 5/9; 
        Console.WriteLine($"{fahrenheit} degrees Fahrenheit is {celsiusDegree} degrees Celsius.");
    }

    // Define your functions below:
    public static void CheckForPositiveNegativeZero(int number)
    {
        if (number < 0)
            Console.WriteLine("Your number is negative.");
        else if (number > 0)
            Console.WriteLine("Your number is positive.");
        else
            Console.WriteLine("Your number is zero.");
    }

    public static void FindMinimum(int num1, int num2, int num3)
    {
        if (num1 < num2 && num1 < num3)
            Console.WriteLine($"The minimum value is {num1}.");
        else if (num2 < num1 && num2 < num3)
            Console.WriteLine($"The minimum value is {num2}.");
        else if (num3 < num1 && num3 < num2)
            Console.WriteLine($"The minimum value is {num3}.");
        else
            Console.WriteLine("There's a tie for minimum.");
    }

    public static void FindMaximum(int num1, int num2, int num3)
    {
        if (num1 > num2 && num1 > num3)
            Console.WriteLine($"The maximum value is {num1}.");
        else if (num2 > num1 && num2 > num3)
            Console.WriteLine($"The maximum value is {num2}.");
        else if (num3 > num1 && num3 > num2)
            Console.WriteLine($"The maximum value is {num3}.");
        else
            Console.WriteLine("There's a tie for maximum.");
    }

    public static void IsDivisibleBy5(int number)
    {
        if (number % 5 == 0)
            Console.WriteLine($"{number} is divisible by 5.");
        else
            Console.WriteLine($"{number} is not divisible by 5.");
    }

    public static void CheckEvenOrOdd(int number)
    {
        if (number % 2 == 0)
            Console.WriteLine($"{number} is an even number.");
        else
            Console.WriteLine($"{number} is an odd number.");
    }

    public static void CheckVowelOrConsonant(char letter)
    {
        switch (letter)
        {
            case 'a':
            case 'A':
            case 'e':
            case 'E':
            case 'i':
            case 'I':
            case 'o':
            case 'O':
            case 'u':
            case 'U':
                Console.WriteLine($"{letter} is a vowel.");
                break;
            case 'w':
            case 'W':
            case 'y':
            case 'Y':
                Console.WriteLine($"{letter} is a semivowel.");
                break;
            default:
                Console.WriteLine($"{letter} is a consonant.");
                break;
        }
    }

    public static void DisplayDayOfWeek(int dayCode)
    {
        int simple = dayCode % 7;

        switch (simple)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            default:
                Console.WriteLine("Sunday");
                break;
        }
    }
}
