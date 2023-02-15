/*
Задача 13: Напишите программу, которая выводит третью цифру заданного семизначного числа или сообщает, что третьей цифры нет.
78 -> третьей цифры нет
3267900 -> 6
ДОП: цифра третья может быть как с левой стороны, так и с правой
*/


/*

--------------------------------------------Первый-способ-(читерский)-------------------------------------------------------
Составил алгоритм решения этой задачи с переводом числа в массив и дальнейшем указании третьего индекса. К сожалению не знал
какую команду прописывать. Путем проб и ошибок так и не выяснил. Так что пришлось гуглить.


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 0)
{
    number = number * (-1);
}

var array = number.ToString().Select(t=>int.Parse(t.ToString())).ToArray(); //<--- Эту команду подсмотрел в интернете. 

if (array.Length > 2)
{   
    Console.WriteLine($"Третьим числом является {array[2]}");
    Console.WriteLine($"Третьим числом с конца является {array[array.Length - 3]}");
}
else
{
    Console.WriteLine($"Число {number} не является трёхкратным");
}
-------------------------------------------------------------------------------------------------------------------------*/



/*--------------------------------------------------Второй-способ-(получитерский-:))---------------------------------------

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 0)
{
    number = number * (-1);
}

var array = number.ToString().Select(t=>int.Parse(t.ToString())).ToArray();
int b = 0;

if (number > 99)
{   
    var a = array [2];
    b = (number % 1000) / 100;
    Console.WriteLine($"Третьим числом является: {a}");
    Console.WriteLine($"Третьим числом с конца является: {b}");
}
else
{
    Console.WriteLine($"Число {number} не является трёхкратным");
}
*/

//--------------------------------------------------Третий-способ-(математический)-----------------------------------------

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 0)
{
    number = number * (-1);
}

double numLen = 0;
int b = 0;

if (number > 99)
{   
    numLen =  Math.Floor(Math.Log10(Math.Abs(number)) + 1);
    b = (number % 1000) / 100;
    Console.WriteLine($"Третьим числом является: {numLen}");
    Console.WriteLine($"Третьим числом с конца является: {b}");
}
else
{
    Console.WriteLine($"Число {number} не является трёхкратным");
}