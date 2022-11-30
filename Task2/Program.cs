//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Не использовать строки

//456 -> 5
//782 -> 8
//918 -> 1

Console.Write("Введите трёхзначное число > ");
int value1 = Convert.ToInt32(Console.ReadLine());

bool ValidateNumber(int Number)
{
    if(Number >=100 && Number < 1000)
    {
        return true;
    }

    System.Console.WriteLine($"Число не трёхзначное");
    return false;
}

if(ValidateNumber(value1))
{
    int secondNumber = (value1/10)%10;
    System.Console.WriteLine($"Вторая цифра числа {secondNumber}");
}