﻿string[] array = new string[] { "alfa", "omega3", "yes", "no" }; // Создиние изначального массива
System.Console.Write("Изначальный массив: "+"[" + string.Join(" ", array) + "]"); // Вывод изначального массива
System.Console.WriteLine(); 
string[] filteredArray = new string[array.Length]; // Создание нового массива для отфильтрованных элементов перед циклом

int filteredIndex = 0; // Индекс для добавления элементов в filteredArray

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        filteredArray[filteredIndex] = array[i];
        filteredIndex++; 
    }
}
// Вывод отфильтрованного массива
System.Console.Write("Массив по заданию: "+"[" + string.Join(" ", filteredArray) + "]");