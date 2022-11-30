//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. Не использовать строки

//6 -> да
//7 -> да
//1 -> нет

Console.Write("Введите номер дня недели > ");
int value1 = Convert.ToInt32(Console.ReadLine());

bool ValidateNumber(int Number)
{
    if(Number > 0 && Number <= 7)
    {
        return true;
    }
    System.Console.WriteLine($"Введено неверное число");
    return false;
}

if(ValidateNumber(value1))
{
    if(value1 == 6 || value1 == 7)
    {
        System.Console.WriteLine($"Этот день выходной");
    }
    else
    {
        System.Console.WriteLine($"Это будний день");
    }
}