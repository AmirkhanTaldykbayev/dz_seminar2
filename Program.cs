/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999)
{
    number = number / 10;
    number = number % 10;
    Console.WriteLine($"Вторым числом является {number}");
}
else
{
    Console.WriteLine($"Число {number} не является трёхзначным");
}

