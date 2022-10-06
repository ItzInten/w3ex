Random rand = new Random();
int number1 = rand.Next(0, 100);
int number2 = rand.Next(0, 100);
Console.WriteLine("Your first number is " + number1);
Console.WriteLine("Your second number is " + number2);
Console.Write("Choose the option you want to do with these numbers: ");
while (true)
{
    try
    {
        char option = Convert.ToChar(Console.ReadLine());
        double result;
        switch (option)
        {
            case '+':
                result = number1 + number2;
                Console.WriteLine("Your result is " + result);
                goto repeat;
            case '-':
                result = number1 - number2;
                Console.WriteLine("Your result is " + result);
                goto repeat;
            case '*':
                result = number1 * number2;
                Console.WriteLine("Your result is " + result);
                goto repeat;
            case '/':
                result = number1 / number2;
                Console.WriteLine("Your result is " + result);
                goto repeat;
            default:
                Console.Write("You've put something wrong ");
                goto repeat;
        }
    }
    catch
    {
        Console.Write("You've put something wrong ");
    }
}
repeat:
Console.ReadKey();