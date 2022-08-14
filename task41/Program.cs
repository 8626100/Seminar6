﻿// Задача 41: Пользователь вводит с клавиатуры M чисел в одну линию (не используем Enter).
//Числа разделены пробелами. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0 7 8 -2 -2 -> 2
//1, -7, 567, 89, 223-> 3


int [] numbers = Console.ReadLine().Split().Select(x=>Convert.ToInt32(x)).ToArray();
Console.WriteLine($"[{string.Join(",",numbers)}]");
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i]>0)
    {
        sum++;
    }
}
Console.WriteLine($"Количество элементов массива, больших нуля, = {sum}");