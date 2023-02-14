﻿/*
Задача 13: Напишите программу, которая выводит третью цифру заданного семизначного числа или сообщает, что третьей цифры нет.
78 -> третьей цифры нет
3267900 -> 6
ДОП: цифра третья может быть как с левой стороны, так и с правой
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
var array = number.ToString().Select(t=>int.Parse(t.ToString())).ToArray();

if (array.Length > 3)
{
    Console.WriteLine($"Третьим числом является {array[2]}");
    Console.WriteLine($"Третьим числом с конца является {array[array.Length - 3]}");
}
else
{
    Console.WriteLine($"Число {number} не является трёхкратным");
}