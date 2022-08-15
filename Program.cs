// Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
string? number = Console.ReadLine();

void CheckingNumber(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine($"Данное число: {number} - это палиндром");
    }
    else Console.WriteLine($"Данное число: {number} - это НЕ палиндром");
}

if (number!.Length == 5)
{
    CheckingNumber(number);
}
else Console.WriteLine($"Это не пятизначное число!");
