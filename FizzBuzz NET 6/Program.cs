bool Fizz(int num)
{

    double remainder = num % 3;

    if (remainder == 0)
    {

        return true;

    }
    else
    {

        return false;

    }

}

bool Buzz(int num)
{

    double remainder = num % 5;

    if (remainder == 0)
    {

        return true;

    } else
    {

        return false;

    }

}

bool FizzBuzz(int num)
{

    double remainderThree = num % 3;
    double remainderFive = num % 5;

    if (remainderThree == 0 && remainderFive == 0)
    {

        return true;

    }
    else
    {

        return false;

    }

}

for(int i = 1; i < 250; i++)
{

    bool passed = false;

    if (FizzBuzz(i) && !passed)
    {

        Console.WriteLine("FizzBuzz");
        passed = true;

    } else if (Buzz(i) && !passed)
    {

        Console.WriteLine("Buzz");
        passed = true;

    } else if (Fizz(i) && !passed)
    {

        Console.WriteLine("Fizz");
        passed = true;

    } else
    {

        Console.WriteLine(i.ToString());

    }

}