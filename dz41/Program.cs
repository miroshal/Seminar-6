﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Prompt(string massege)
{
    System.Console.Write(massege);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int Main(int number)
{
    int[] array = new int[number];
    int greaterZero = 0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($"Введи значение для {i} индекса: ");
        if (array[i] > 0) greaterZero ++;
    }
    return greaterZero;
}

Console.WriteLine($">>> {Main(Prompt("Введи количество чисел: "))}");