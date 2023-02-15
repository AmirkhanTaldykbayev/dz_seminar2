/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите число: ");
int day = Convert.ToInt32(Console.ReadLine());
int index = 0;
int [] weekday = {1, 2, 3, 4, 5};
int [] weekend = {6, 7};

if (day >= 1 && day <= 7)
{
    while(index < weekday.Length)
    {
         if (day == weekday[index])
        {
            Console.WriteLine("Будний день :(");
            break;
        }
        else if (day == weekend[0] || day == weekend[1])
        {
            Console.WriteLine("Ура, выходной!");
            break;
        }
    index++;
    }
}
else
{
    Console.WriteLine("Введено неверное число");
}