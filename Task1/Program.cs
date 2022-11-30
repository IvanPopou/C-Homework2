//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. Не использовать строки для расчета

//456 -> 46
//782 -> 72
//918 -> 98

int value1 = new Random().Next(100,1000);
Console.WriteLine($"Generated number is {value1}");

int withoutSecondNumber = ((value1)/100)*10+value1%10;

Console.WriteLine($"The number without second digit is {withoutSecondNumber}");