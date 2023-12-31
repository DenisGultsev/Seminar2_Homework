﻿// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int ThirdDigit(int number) // Метод, который находит третью цифру числа
{
    int result = -1; // Изначально предполагаем, что третьей цифры нет
    if (number >= 100) // Если число содержит по крайней мере 3 цифры
    {
        while (number > 999) // Удаляем все цифры числа, кроме первых трех
        {
            number = number / 10;
        }
        result = number % 10; // Находим третью цифру, она будет крайней правой в оставшемся числе
    }
    return result; // Возвращаем результат
}
Console.Write("Введите число: "); // Запрашиваем у пользователя число и выводим третью цифру
int number = Convert.ToInt32(Console.ReadLine());

if (ThirdDigit(number) == -1) // Если третьей цифры нет, выводим сообщение
    Console.WriteLine($"{number} → Третьей цифры нет.");
else // Иначе выводим третью цифру
    Console.WriteLine($"{number}: Третья цифра → {ThirdDigit(number)}");
