int Factorial(int number)
{
    if (number == 1)
        return 1;
    else
        return number * Factorial(number - 1);
}

int a = 7;
Console.WriteLine(Factorial(a));
