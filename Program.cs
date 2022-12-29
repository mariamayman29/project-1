// See https://aka.ms/new-console-template for more information


Console.WriteLine("Enter two integers to know the prime numbers between them");

int num1 = int.Parse(Console.ReadLine());

int num2 = int.Parse(Console.ReadLine());

if (num2 <= 1)
{
    Console.WriteLine("there is no prime numbers");
}

else
{

    Boolean flag = true;

    for (; num1 <= num2; num1++)
    {
        if (num1 < 2 || num2 < 2)
            continue;

        for (int i = 2; i <= num1 / 2; i++)
        {

            if (num1 % i == 0)
            {
                flag = false;
                break;
            }
        }
        if (flag == true)

        {
            Console.WriteLine("{0} is a prime number", num1);

        }
        flag = true;
    }
}
