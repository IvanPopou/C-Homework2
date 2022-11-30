//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. . Не использовать строки

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Введите число > ");
int value1 = Convert.ToInt32(Console.ReadLine());

bool ValidateNumber(int Number)
{
    if(Number < 100)
    {
        System.Console.WriteLine($"Третьей цифры нет");
        return false;
    }
    else if(Number >= 100 && Number <1000)
    {
        System.Console.WriteLine($"Третья цифра числа равна {Number%10}");
        return false;
    }
    return true;
}

while(ValidateNumber(value1))
{
    value1 = value1/10;
}




